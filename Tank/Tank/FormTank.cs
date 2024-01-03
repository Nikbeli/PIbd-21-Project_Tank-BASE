using Tank.DrawningObjects;
using Tank.MovementStrategy;

namespace Tank
{
    public partial class FormTank : Form
    {
        private DrawArmoVehicle? _Tank;
        private AbstractStrategy? _abstractStrategy;
        public DrawArmoVehicle? SelectedTank { get; private set; }

        public FormTank()
        {
            InitializeComponent();
            _abstractStrategy = null;
            SelectedTank = null;
        }

        private void Draw()
        {
            if (_Tank == null)
                return;

            Bitmap bitmap = new(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            _Tank?.DrawTransport(gr);
            pictureBoxTank.Image = bitmap;
        }


        private void ButtonCreateTank_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color mainColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mainColor = dialog.Color;
            }
            Color addColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                addColor = dialog.Color;
            }

            _Tank = new DrawTank(rnd.Next(100, 200), rnd.Next(2000, 4000),
               mainColor, addColor,
                Convert.ToBoolean(rnd.Next(1, 2)), Convert.ToBoolean(rnd.Next(1, 2)), Convert.ToBoolean(rnd.Next(1, 2)),
                pictureBoxTank.Width, pictureBoxTank.Height);
            _Tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100));
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            if (_Tank == null)
                return;

            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "keyUp":
                    _Tank?.MoveTransport(Direction.Up);
                    break;
                case "keyDown":
                    _Tank?.MoveTransport(Direction.Down);
                    break;
                case "keyLeft":
                    _Tank?.MoveTransport(Direction.Left);
                    break;
                case "keyRight":
                    _Tank?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }


        private void CreateButtonArmoVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }

            _Tank = new DrawArmoVehicle(rnd.Next(100, 200), rnd.Next(2000, 4000),
               color, pictureBoxTank.Width, pictureBoxTank.Height);

            _Tank.SetPosition(rnd.Next(10, 50), rnd.Next(30, 70));
            Draw();
        }


        private void ButtonStep_Click(object sender, EventArgs e)
        {
            if (_Tank == null)
                return;
            if (comboBoxStrategy.Enabled)
            {
                _abstractStrategy = comboBoxStrategy.SelectedIndex switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null
                };
                if (_abstractStrategy == null)
                    return;
                _abstractStrategy.SetData(new DrawingObjectTank(_Tank), pictureBoxTank.Width, pictureBoxTank.Height);
                comboBoxStrategy.Enabled = false;
            }
            if (_abstractStrategy == null)
                return;
            _abstractStrategy.MakeStep();
            Draw();
            if (_abstractStrategy.GetStatus() == Status.Finish)
            {
                comboBoxStrategy.Enabled = true;
                _abstractStrategy = null;
            }
        }

        private void ButtonSelectTank_Click(object sender, EventArgs e)
        {
            SelectedTank = _Tank;
            DialogResult = DialogResult.OK;
        }
    }
}
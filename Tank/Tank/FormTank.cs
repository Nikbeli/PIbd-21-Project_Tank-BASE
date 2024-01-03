namespace Tank
{
    public partial class FormTank : Form
    {
        private DrawingTank _Tank;
        public FormTank()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _Tank?.DrawTransport(gr);
            pictureBoxTank.Image = bmp;
        }
        private void PictureBoxTank_Resize(object sender, EventArgs e)
        {
            _Tank?.ChangeBorders(pictureBoxTank.Width, pictureBoxTank.Height);
            Draw();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _Tank = new DrawingTank();
            _Tank.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), 0, pictureBoxTank.Width, pictureBoxTank.Height, true, true, true);
            _Tank.SetPosition(rnd.Next(10, 50), rnd.Next(30, 70), pictureBoxTank.Width, pictureBoxTank.Height);
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
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
    }
}
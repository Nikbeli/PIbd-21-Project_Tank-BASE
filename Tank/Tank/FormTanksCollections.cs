using Tank.DrawningObjects;
using Tank.Generics;
using Tank.MovementStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class FormTanksCollections : Form
    {
        private readonly TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank> _tanks;

        public FormTanksCollections()
        {
            InitializeComponent();
            _tanks = new TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>(DrawTank.Width, DrawTank.Height);
        }

        private void ButtonAddTank_Click(object sender, EventArgs e)
        {
            FormTank form = new FormTank();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (_tanks + form.SelectedTank != -1)
                {
                    MessageBox.Show("Объект добавлен");
                    DrawTank.Image = _tanks.ShowTanks();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }
        private void ButtonRemoveTank_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить объект?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = -1;
            try
            {
                pos = Convert.ToInt32(InputNum.Text);
            }
            catch (Exception ex) { }
            if (_tanks - pos)
            {
                MessageBox.Show("Объект удален");
                DrawTank.Image = _tanks.ShowTanks();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonRefreshCollection_Click(object sender, EventArgs e)
        {
            DrawTank.Image = _tanks.ShowTanks();
        }
    }
}

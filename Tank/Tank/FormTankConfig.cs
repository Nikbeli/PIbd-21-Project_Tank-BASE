using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tank.DrawningObjects;
using Tank.Entities;

namespace Tank
{
    public partial class FormTankConfig : Form
    {
        Color defaultColor;

        // Переменная-выбранный танк
        DrawArmoVehicle _tank = null;

        // Событие
        private event Action<DrawArmoVehicle> EventAddTank;

        // Конструктор
        public FormTankConfig()
        {
            InitializeComponent();

            panelSilver.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelCyan.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;

            defaultColor = labelColor.BackColor;
            buttonCancel.Click += (s, e) => Close();
        }

        // Отрисовать танк
        private void DrawingTank()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _tank?.SetPosition(5, 5);
            if (_tank is DrawTank)
                (_tank as DrawTank).DrawTransport(gr);
            else
                _tank?.DrawTransport(gr);
            pictureBox.Image = bmp;
        }

        // Добавление события
        internal void AddEvent(Action<DrawArmoVehicle> ev)
        {
            if (EventAddTank == null)
            {
                EventAddTank = ev;
            }
            else
            {
                EventAddTank += ev;
            }
        }

        // Передаем информацию при нажатии на Label
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label)?.DoDragDrop((sender as Label)?.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.Text) ?? false)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Действия при приеме перетаскиваемой информации
        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data?.GetData(DataFormats.Text).ToString())
            {
                case "labelArmoVehicle":
                    _tank = new DrawArmoVehicle((int)numericSpeed.Value, (int)numericWeight.Value, Color.White, pictureBox.Width, pictureBox.Height);
                    break;
                case "labelTank":
                    _tank = new DrawTank((int)numericSpeed.Value, (int)numericWeight.Value, Color.White, Color.Black, checkBoxBodyKit.Checked, checkBoxCaterpillar.Checked, checkBoxTower.Checked, pictureBox.Width, pictureBox.Height);
                    break;
            }
            labelColor.BackColor = defaultColor;
            labelAdditionalColor.BackColor = defaultColor;
            DrawingTank();
        }

        // Добавление танка
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddTank?.Invoke(_tank);
            Close();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(typeof(Color)) ?? false)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_tank == null)
                return;
            ((Label)sender).BackColor = (Color)e.Data.GetData(typeof(Color));
            switch (((Label)sender).Name)
            {
                case "labelColor":
                    _tank.Tank.setBodyColor((Color)e.Data.GetData(typeof(Color)));
                    break;
                case "labelAdditionalColor":
                    if (!(_tank is DrawTank))
                        return;
                    (_tank.Tank as EntityTank).setAdditionalColor((Color)e.Data.GetData(typeof(Color)));
                    break;
            }
            DrawingTank();
        }
    }
}
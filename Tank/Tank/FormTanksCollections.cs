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
        private readonly TanksGenericStorage _storage;

        // Конструктор
        public FormTanksCollections()
        {
            InitializeComponent();
            _storage = new TanksGenericStorage(DrawTank.Width, DrawTank.Height);
        }

        private void ReloadObjects()
        {
            int index = CollectionListBox.SelectedIndex;
            CollectionListBox.Items.Clear();
            foreach (var key in _storage.Keys)
            {
                CollectionListBox.Items.Add(key);
            }
            if (CollectionListBox.Items.Count > 0 && (index == -1 || index
            >= CollectionListBox.Items.Count))
            {
                CollectionListBox.SelectedIndex = 0;
            }
            else if (CollectionListBox.Items.Count > 0 && index > -1 &&
            index < CollectionListBox.Items.Count)
            {
                CollectionListBox.SelectedIndex = index;
            }
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SetTextBox.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _storage.AddSet(SetTextBox.Text);
            ReloadObjects();
        }

        private void ListBoxObjects_SelectedIndexChanged(object sender,
        EventArgs e)
        {
            DrawTank.Image =
            _storage[CollectionListBox.SelectedItem?.ToString() ?? string.Empty]?.ShowTanks();
        }

        private void ButtonDelObject_Click(object sender, EventArgs e)
        {
            if (CollectionListBox.SelectedIndex == -1)
            {
                return;
            }
            if (MessageBox.Show($"Удалить объект {CollectionListBox.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _storage.DelSet(CollectionListBox.SelectedItem.ToString() ?? string.Empty);
                ReloadObjects();
            }
        }

        private void AddTank(DrawArmoVehicle tank)
        {
            if (CollectionListBox.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
            {
                return;
            }
            if ((obj + tank) != false)
            {
                MessageBox.Show("Объект добавлен");
                DrawTank.Image = obj.ShowTanks();
            }
            else
            {
                MessageBox.Show("Не удалось добавить объект");
            }
        }

        private void ButtonAddTank_Click(object sender, EventArgs e)
        {
            // Проверка на вызов формочки
            if (CollectionListBox.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
            {
                return;
            }
            FormTankConfig form = new FormTankConfig();
            form.Show();
            form.AddEvent(AddTank);
        }

        private void ButtonRemoveTank_Click(object sender, EventArgs e)
        {
            if (CollectionListBox.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ??
            string.Empty];
            if (obj == null)
            {
                return;
            }

            if (MessageBox.Show("Удалить объект?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(InputNum.Text);
            if (obj - pos != null)
            {
                MessageBox.Show("Объект удален");
                DrawTank.Image = obj.ShowTanks();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonRefreshCollection_Click(object sender, EventArgs e)
        {
            if (CollectionListBox.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ??
            string.Empty];
            if (obj == null)
            {
                return;
            }
            DrawTank.Image = obj.ShowTanks();
        }
    }
}

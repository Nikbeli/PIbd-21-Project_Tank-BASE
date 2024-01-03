using Microsoft.Extensions.Logging;
using Tank.Exceptions;
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

        // Логгер 
        private readonly ILogger _logger;

        // Конструктор
        public FormTanksCollections(ILogger<FormTanksCollections> logger)
        {
            InitializeComponent();
            _storage = new TanksGenericStorage(DrawTank.Width, DrawTank.Height);
            _logger = logger;
        }

        private void ReloadObjects()
        {
            int index = CollectionListBox.SelectedIndex;
            CollectionListBox.Items.Clear();
            foreach (var key in _storage.Keys)
            {
                CollectionListBox.Items.Add(key.Name);
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
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning("Коллекция не добавлена, не все данные заполнены");
                return;
            }
            _storage.AddSet(SetTextBox.Text);
            ReloadObjects();

            _logger.LogInformation($"Добавлен набор: {SetTextBox.Text}");
        }

        private void ListBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawTank.Image = _storage[CollectionListBox.SelectedItem?.ToString() ?? string.Empty]?.ShowTanks();
        }

        private void ButtonDelObject_Click(object sender, EventArgs e)
        {
            if (CollectionListBox.SelectedIndex == -1)
            {
                _logger.LogWarning("Удаление невыбранного набора");
                return;
            }
            string nameSet = CollectionListBox.SelectedItem.ToString() ?? string.Empty;
            if (MessageBox.Show($"Удалить объект {nameSet}?", "Удаление", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _storage.DelSet(nameSet);
                ReloadObjects();
                _logger.LogInformation($"Набор '{nameSet}' удален");
            }
            _logger.LogWarning("Отмена удаления набора");
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
                _logger.LogWarning("Добавление пустого объекта");
                return;
            }

            try
            {
                if ((obj + tank) != false)
                {
                    MessageBox.Show("Объект добавлен");
                    DrawTank.Image = obj.ShowTanks();
                    _logger.LogInformation($"Добавлен объект {obj}");
                }
            }
            catch (TankStorageOverflowException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Не удалось добавить объект");
                _logger.LogWarning($"{ex.Message} в наборе {CollectionListBox.SelectedItem.ToString()}");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                _logger.LogWarning($"добавление танка неуспешно {ex.Message}");
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
                _logger.LogWarning("Удаление объекта из несуществующего набора");
                return;
            }
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
            {
                return;
            }

            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                _logger.LogWarning("Отмена удаления объекта");
                return;
            }
            int pos = Convert.ToInt32(InputNum.Text);
            try
            {
                if (obj - pos != null)
                {
                    MessageBox.Show("Объект удален");
                    _logger.LogInformation($"Удален объект с позиции{pos}");
                    DrawTank.Image = obj.ShowTanks();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить объект");
                    _logger.LogWarning($"Не удалось удалить объект из набора {CollectionListBox.SelectedItem.ToString()}");
                }
            }
            catch (TankNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                _logger.LogWarning($"{ex.Message} из набора {CollectionListBox.SelectedItem.ToString()}");
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Данные загружены в файл {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogWarning($"Не удалось сохранить информацию в файл: {ex.Message}");
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.LoadData(openFileDialog.FileName);
                    ReloadObjects();
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Данные загружены из файла {openFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не загрузилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogWarning($"Не удалось загрузить информацию из файла: {ex.Message}");
                }
            }
        }

        private void ButtonSortByType_Click(object sender, EventArgs e) => CompareTank(new TankCompareByType());

        private void ButtonSortByColor_Click(object sender, EventArgs e) => CompareTank(new TankCompareByColor());

        private void CompareTank(IComparer<DrawArmoVehicle?> comparer)
        {
            if (CollectionListBox.SelectedIndex == -1)
                return;
            var obj = _storage[CollectionListBox.SelectedItem.ToString() ?? string.Empty];
            if (obj == null)
                return;
            obj.Sort(comparer);
            DrawTank.Image = obj.ShowTanks();
        }
    }
}
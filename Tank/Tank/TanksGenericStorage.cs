using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.Generics;
using Tank.DrawningObjects;
using Tank.MovementStrategy;
using Tank.Exceptions;
using Tank.Entities;

namespace Tank
{
    internal class TanksGenericStorage
    {
        // Словарь
        readonly Dictionary<TankCollectionInfo, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> _tankStorages;

        // Возвращение списка названий наборов
        public List<TankCollectionInfo> Keys => _tankStorages.Keys.ToList();
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        private static readonly char _separatorForKeyValue = '|';
        private readonly char _separatorRecords = ';';
        private static readonly char _separatorForObject = ':';

        // Конструктор
        public TanksGenericStorage(int pictureWidth, int pictureHeight)
        {
            _tankStorages = new Dictionary<TankCollectionInfo, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        // Добавление набора
        public void AddSet(string name)
        {
            TankCollectionInfo Info = new TankCollectionInfo(name, string.Empty);
            if (_tankStorages.ContainsKey(Info)) return;
            _tankStorages[Info] = new TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>(_pictureWidth, _pictureHeight);
        }

        // Удаление набора
        public void DelSet(string name)
        {
            TankCollectionInfo Info = new TankCollectionInfo(name, string.Empty);
            if (!_tankStorages.ContainsKey(Info)) return;
            _tankStorages.Remove(Info);
        }

        // Доступ к набору
        public TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>?
        this[string ind]
        {
            get
            {
                TankCollectionInfo Info = new TankCollectionInfo(ind, string.Empty);
                if (_tankStorages.ContainsKey(Info)) return _tankStorages[Info];
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            StringBuilder data = new();
            foreach (KeyValuePair<TankCollectionInfo, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> record in _tankStorages)
            {
                StringBuilder records = new();
                foreach (DrawArmoVehicle? elem in record.Value.GetTanks)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key.Name}{_separatorForKeyValue}{records}");

            }
            if (data.Length == 0)
            {
                throw new InvalidOperationException("File not found, невалиданя операция, нет данных для сохранения");
            }
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("TankStorage");
                writer.Write(data.ToString());
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Файл не найден");
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string checker = reader.ReadLine();
                if (checker == null)
                    throw new NullReferenceException("Нет данных для загрузки");
                if (!checker.StartsWith("TankStorage"))
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат данных");
                }

                _tankStorages.Clear();
                string strs;
                bool firstinit = true;
                while ((strs = reader.ReadLine()) != null)
                {
                    if (strs == null && firstinit)
                        throw new NullReferenceException("Нет данных для загрузки");
                    if (strs == null)
                        break;
                    firstinit = false;
                    string name = strs.Split('|')[0];
                    TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank> collection = new(_pictureWidth, _pictureHeight);
                    foreach (string data in strs.Split('|')[1].Split(';'))
                    {
                        DrawArmoVehicle? vehicle = data?.CreateDrawTank(_separatorForObject, _pictureWidth, _pictureHeight);
                        if (vehicle != null)
                        {
                            try
                            {
                                _ = collection + vehicle;
                            }
                            catch (TankNotFoundException e)
                            {
                                throw e;
                            }
                            catch (TankStorageOverflowException e)
                            {
                                throw e;
                            }
                        }
                    }
                    _tankStorages.Add(new TankCollectionInfo(name, string.Empty), collection);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.Generics;
using Tank.DrawningObjects;
using Tank.MovementStrategy;

namespace Tank
{
    internal class TanksGenericStorage
    {
        // Словарь
        readonly Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> _tankStorages;

        // Возвращение списка названий наборов
        public List<string> Keys => _tankStorages.Keys.ToList();
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        private static readonly char _separatorForKeyValue = '|';
        private readonly char _separatorRecords = ';';
        private static readonly char _separatorForObject = ':';

        // Конструктор
        public TanksGenericStorage(int pictureWidth, int pictureHeight)
        {
            _tankStorages = new Dictionary<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        // Добавление набора
        public void AddSet(string name)
        {
            if (_tankStorages.ContainsKey(name)) return;
            _tankStorages[name] = new TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>(_pictureWidth, _pictureHeight);
        }

        // Удаление набора
        public void DelSet(string name)
        {
            if (!_tankStorages.ContainsKey(name)) return;
            _tankStorages.Remove(name);
        }

        // Доступ к набору
        public TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>?
        this[string ind]
        {
            get
            {
                if (_tankStorages.ContainsKey(ind)) return _tankStorages[ind];
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            StringBuilder data = new();
            foreach (KeyValuePair<string, TanksGenericCollection<DrawArmoVehicle, DrawingObjectTank>> record in _tankStorages)
            {
                StringBuilder records = new();
                foreach (DrawArmoVehicle? elem in record.Value.GetTanks)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key}{_separatorForKeyValue}{records}");
            }

            if (data.Length == 0)
            {
                return false;
            }
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("TankStorage");
                writer.Write(data.ToString());
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader reader = new StreamReader(filename))
            {
                string checker = reader.ReadLine();
                if (checker == null)
                    return false;
                if (!checker.StartsWith("TankStorage"))
                    return false;
                _tankStorages.Clear();
                string strs;
                bool firstinit = true;
                while ((strs = reader.ReadLine()) != null)
                {
                    if (strs == null && firstinit)
                        return false;
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
                            if (!(collection + vehicle))
                            {
                                return false;
                            }
                        }
                    }
                    _tankStorages.Add(name, collection);
                }
                return true;
            }
        }
    }
}
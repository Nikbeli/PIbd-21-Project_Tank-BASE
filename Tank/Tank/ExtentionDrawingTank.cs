using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank.DrawningObjects;
using Tank.Entities;

namespace Tank
{
    public static class ExtentionDrawingTank
    {
        public static DrawArmoVehicle? CreateDrawTank(this string info, char separatorForObject, int width, int height)
        {
            string[] strs = info.Split(separatorForObject);
            if (strs.Length == 3)
            {
                return new DrawArmoVehicle(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]), Color.FromName(strs[2]), width, height);
            }
            if (strs.Length == 7)
            {
                return new DrawTank(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]),
                Color.FromName(strs[2]),
                Color.FromName(strs[3]),
                Convert.ToBoolean(strs[4]),
                Convert.ToBoolean(strs[5]),
                Convert.ToBoolean(strs[6]), width, height);
            }
            return null;
        }

        public static string GetDataForSave(this DrawArmoVehicle vehicle, char separatorForObject)
        {
            var Vehicle = vehicle.Tank;
            if (Vehicle == null)
            {
                return string.Empty;
            }
            var str = $"{Vehicle.Speed}{separatorForObject}{Vehicle.Weight}{separatorForObject}{Vehicle.BodyColor.Name}";
            if (Vehicle is not EntityTank tank)
            {
                return str;
            }
            return $"{str}{separatorForObject}{tank.AdditionalColor.Name}{separatorForObject}{tank.BodyKit}{separatorForObject}{tank.Caterpillar}{separatorForObject}{tank.Tower}";
        }
    }
}
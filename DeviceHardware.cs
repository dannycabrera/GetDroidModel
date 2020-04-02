using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace GetDroidModel
{
    class Droid 
    {
        public string Manufacturer { get; set; }
        public string MarketingName { get; set; }
        public string Device { get; set; }
        public string Model { get; set; }
    }

    public static class DeviceHardware
    {
        /// <summary>
        /// Reads the device file assets file.
        /// </summary>
        static IEnumerable<string> ReadDeviceFile()
        {
            string line;
            using (var reader = new StreamReader(Android.App.Application.Context.Assets.Open("supported_devices.csv")))
            {
                while ((line = reader.ReadLine()) != null)
                    yield return line;
            }
        }

        /// <summary>
        /// Parses the line.
        /// </summary>
        /// <param name="line">Devices.csv file line.</param>
        static Droid ParseLine(string line)
        {
            //Retail Branding, Marketing Name,Device,Model
            var parms = line.Split(',');

            return new Droid() { Manufacturer=parms[0], MarketingName=parms[1], Device=parms[2], Model=parms[3]};
        }

        /// <summary>
        /// Gets the Android model.
        /// </summary>
        /// <param name="defaultValue">Default value.</param>
        public static string GetModel(string defaultValue = "Unknown", bool includeManufacturer = false)
        {
            var droidDevice = (from line in ReadDeviceFile()
                   let droid = ParseLine(line)
                   where droid.Model == Android.OS.Build.Model || droid.Device == Android.OS.Build.Model
                   select droid).FirstOrDefault();

            if (droidDevice == null)
                return defaultValue;
            else
            {
                var deviceName = droidDevice.MarketingName == "" ? droidDevice.Model : droidDevice.MarketingName;

                if (includeManufacturer && !deviceName.StartsWith(droidDevice.Manufacturer, System.StringComparison.OrdinalIgnoreCase))
                    return $"{droidDevice.Manufacturer} {deviceName}";
                
                return deviceName;
            }
        }
    }
}
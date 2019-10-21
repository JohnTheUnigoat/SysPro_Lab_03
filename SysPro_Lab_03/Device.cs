using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_03
{
    class Device
    {
        public enum DeviceType { Mouse, Keyboard, HDD, Ram, Flash, Printer, Scaner, Speakers, Phone, Micrphone, Headphones, Monitor };

        private DeviceType deviceType;

        public string Name { get; private set; }

        public string Manufacturer { get; private set; }

        public string Type
        {
            get
            {
                return deviceType.ToString();
            }
        }

        public PortType PortType { get; }

        public bool IsConnected { get; set; }

        public Device(string Name, string Manufacturer, DeviceType deviceType, PortType portType)
        {
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.deviceType = deviceType;
            PortType = portType;
            IsConnected = false;
        }
        public Device(Device Other)
        {
            Name = Other.Name;
            Manufacturer = Other.Manufacturer;
            deviceType = Other.deviceType;
            PortType = Other.PortType;
            IsConnected = false;
        }

        public static bool operator true(Device dev)
        {
            return dev.IsConnected;
        }

        public static bool operator false(Device dev)
        {
            return !dev.IsConnected;
        }

        public override string ToString()// Manufacturer-Name-Type-(Port)
        {
            StringBuilder DeviceFullName = new StringBuilder();

            DeviceFullName.AppendFormat(Manufacturer);
            DeviceFullName.AppendFormat(Name);
            DeviceFullName.AppendFormat(deviceType.ToString());
            DeviceFullName.Append('(');
            DeviceFullName.AppendFormat(PortType.ToString());
            DeviceFullName.Append(')');

            return DeviceFullName.ToString();
        }
    }
}

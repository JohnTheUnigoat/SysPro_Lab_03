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

        public DeviceType Type { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public PortType PortType { get; set; }

        public bool IsConnected { get; set; }

        public Device(string Name, string Manufacturer, DeviceType deviceType, PortType portType)
        {
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.Type = deviceType;
            PortType = portType;
            IsConnected = false;
        }
        public Device(Device Other)
        {
            Name = Other.Name;
            Manufacturer = Other.Manufacturer;
            Type = Other.Type;
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
            DeviceFullName.AppendFormat(Type.ToString());
            DeviceFullName.Append('(');
            DeviceFullName.AppendFormat(PortType.ToString());
            DeviceFullName.Append(')');

            return DeviceFullName.ToString();
        }
    }
}

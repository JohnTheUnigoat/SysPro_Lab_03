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
    }
}

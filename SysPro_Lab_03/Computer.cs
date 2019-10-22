using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_03
{
    class Computer
    {
        //fields
        private static int currentID = 0;

        public List<Device> devices { get; }

        public class PortInfo
        {
            public int Total { get; set; }
            public int Occupied { get; set; }

            public int Available
            {
                get { return Total - Occupied; }
            }

            public PortInfo(int total, int occupied)
            {
                Total = total;
                Occupied = occupied;
            }

            public override string ToString()
            {
                var sb = new StringBuilder();

                sb.AppendFormat("{0}/{1}", Occupied, Total);

                return sb.ToString();
            }
        }

        private Dictionary<PortType, PortInfo> ports;

        //properties
        public int ID { get; set; }

        public ReadOnlyDictionary<PortType, PortInfo> Ports
        {
            get
            {
                return new ReadOnlyDictionary<PortType, PortInfo>(ports);
            }
        }

        //methods
        public Computer(Dictionary<PortType, int> portsCount)
        {
            ID = currentID++;

            devices = new List<Device>();

            ports = new Dictionary<PortType, PortInfo>();

            foreach(var type in portsCount.Keys)
            {
                ports[type] = new PortInfo(portsCount[type], 0);
            }
        }

        public void ConnectDevice(Device device)
        {
            if (device.IsConnected)
                throw new ArgumentException("Device already in use!");

            if (!ports.Keys.Contains(device.PortType))
                throw new ArgumentException("This computer doesn't support this port!");

            if (ports[device.PortType].Available == 0)
                throw new ArgumentException("All ports of this type are occupied!");

            devices.Add(device);

            device.IsConnected = true;

            ports[device.PortType].Occupied++;
        }

        public bool DisconnectDevice(Device device)
        {
            if (!device.IsConnected)
                return false;

            if (!devices.Contains(device))
                return false;

            ports[device.PortType].Occupied--;

            device.IsConnected = false;

            devices.Remove(device);

            return true;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("№ {0}", ID);

            return sb.ToString();
        }
    }
}

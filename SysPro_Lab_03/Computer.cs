using System;
using System.Collections.Generic;
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

        private Dictionary<PortType, int> totalPorts;

        private Dictionary<PortType, int> availablePorts;

        //properties
        public int ID { get; set; }

        public string[] Ports
        {
            get
            {
                string[] res = new string[totalPorts.Count];

                var sb = new StringBuilder();

                int i = 0;

                foreach (var key in totalPorts.Keys)
                {
                    sb.Clear();
                    sb.Append(key.ToString().Replace('_', ' '));
                    sb.AppendFormat(":\t{0}/{1}", availablePorts[key], totalPorts[key]);

                    res[i] = sb.ToString();
                    ++i;
                }

                return res;
            }
        }

        //methods
        public Computer(params (PortType, int)[] portsCount)
        {
            ID = currentID++;

            devices = new List<Device>();

            totalPorts = new Dictionary<PortType, int>();
            availablePorts = new Dictionary<PortType, int>();

            foreach(var portInfo in portsCount)
            {
                totalPorts[portInfo.Item1] = portInfo.Item2;
                availablePorts[portInfo.Item1] = portInfo.Item2;
            }
        }

        public void ConnectDevice(Device device)
        {
            if (device.IsConnected)
                throw new ArgumentException("Device already in use!");

            if (!availablePorts.Keys.Contains(device.PortType))
                throw new ArgumentException("This computer doesn't support this port!");

            if (availablePorts[device.PortType] == 0)
                throw new ArgumentException("All ports of this type are occupied!");

            devices.Add(device);

            device.IsConnected = true;

            availablePorts[device.PortType]--;
        }

        public bool DisconnectDevice(Device device)
        {
            if (!device.IsConnected)
                return false;

            if (!devices.Contains(device))
                return false;

            availablePorts[device.PortType]++;

            device.IsConnected = false;

            devices.Remove(device);

            return true;
        }
    }
}

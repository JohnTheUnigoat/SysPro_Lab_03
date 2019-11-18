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
        public static int currentID = 0;

        private List<Device> devices;

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

        private List<PortInfo> ports;

        //properties
        public int ID { get; set; }

        public ReadOnlyCollection<Device> Devices
        {
            get
            {
                return new ReadOnlyCollection<Device>(devices);
            }
        }

        public ReadOnlyCollection<PortInfo> Ports
        {
            get
            {
                return new ReadOnlyCollection<PortInfo>(ports);
            }
        }

        public List<string> PortList
        {
            get
            {
                List<string> res = new List<string>();

                var sb = new StringBuilder();

                for(int i = 0; i < ports.Count; i++)
                {
                    sb.Clear();
                    sb.AppendFormat("{0} - {1}", ((PortType)i).ToString().Replace('_', ' '), ports[i].ToString());
                    res.Add(sb.ToString());
                }

                return res;
            }
        }

        //methods
        public Computer(List<int> ports)
        {
            ID = currentID++;

            devices = new List<Device>();
            this.ports = new List<PortInfo>(Program.portTypesCount);

            foreach(var portCount in ports)
            {
                this.ports.Add(new PortInfo(portCount, 0));
            }
        }

        public void ConnectDevice(Device device)
        {
            if (device.IsConnected)
                throw new ArgumentException("Device already in use!");

            if (ports[(int)device.PortType].Total == 0)
                throw new ArgumentException("This computer doesn't support this port!");

            if (ports[(int)device.PortType].Available == 0)
                throw new ArgumentException("All ports of this type are occupied!");

            devices.Add(device);

            device.IsConnected = true;

            ports[(int)device.PortType].Occupied++;
        }

        public bool DisconnectDevice(Device device)
        {
            if (!device.IsConnected)
                return false;

            if (!Devices.Contains(device))
                return false;

            ports[(int)device.PortType].Occupied--;

            device.IsConnected = false;

            devices.Remove(device);

            return true;
        }

        public void SetPortCount(PortType type, int count)
        {
            if (count < ports[(int)type].Occupied)
            {
                var e = new ArgumentException("New port count can't be smaller than the number of occupied ports!");
                e.Data.Add(Program.SetPortExceptionKey, type);
                throw e;
            }
            else
                ports[(int)type].Total = count;
        }

        public void SetPortsCount(List<int> portsCount)
        {
            for (int i = 0; i < portsCount.Count; i++)
                SetPortCount((PortType)i, portsCount[i]);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("№ {0}", ID);

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_03
{
    class DeviceManager
    {
        //fields
        private List<Device> devices;

        private List<Computer> computers;

        private SortedList<Device.DeviceType, int> totalDeviceCount;

        private SortedList<Device.DeviceType, int> unusedDeviceCount;

        //properties
        public ReadOnlyCollection<Computer> Computers
        {
            get
            {
                return computers.AsReadOnly();
            }
        }

        public ReadOnlyCollection<Device> UnusedDevices
        {
            get
            {
                List<Device> res = new List<Device>();

                foreach (var item in devices)
                {
                    if (!item.IsConnected)
                        res.Add(item);
                }

                return res.AsReadOnly();
            }
        }

        public string[] DeviceCount
        {
            get
            {
                string[] res = new string[totalDeviceCount.Count];

                var sb = new StringBuilder();

                int i = 0;

                foreach (var key in totalDeviceCount.Keys)
                {
                    sb.Clear();
                    sb.Append(key.ToString());
                    sb.AppendFormat(":\t{0}/{1}", unusedDeviceCount[key], totalDeviceCount[key]);

                    res[i++] = sb.ToString();
                }

                return res;
            }
        }

        public int ComputerCount
        {
            get
            {
                return computers.Count;
            }
        }

        //methods

        public DeviceManager()
        {
            computers = new List<Computer>();
            devices = new List<Device>();

            totalDeviceCount = new SortedList<Device.DeviceType, int>();
            unusedDeviceCount = new SortedList<Device.DeviceType, int>();
        }

        //computer add/remove/edit
        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void RemoveComputer(int index)
        {
            computers.RemoveAt(index);
        }

        public void EditComputer(int index, int ID, Dictionary<PortType, int> portsCount)
        {
            computers[index].ID = ID;
            computers[index].SetPortsCount(portsCount);
        }

        //device add/remove/edit
        public void AddDevice(Device device)
        {
            devices.Add(device);

            if (totalDeviceCount.ContainsKey(device.Type))
            {
                totalDeviceCount[device.Type]++;
                unusedDeviceCount[device.Type]++;
            }
            else
            {
                totalDeviceCount[device.Type] = 1;
                unusedDeviceCount[device.Type] = 1;
            }
        }

        public void RemoveDevice(Device device)
        {
            if (device.IsConnected)
                throw new ArgumentException("Can't remove connected device!");

            devices.Remove(device);

            totalDeviceCount[device.Type]--;
            unusedDeviceCount[device.Type]--;

            if (totalDeviceCount[device.Type] == 0)
            {
                totalDeviceCount.Remove(device.Type);
                unusedDeviceCount.Remove(device.Type);
            }
        }

        public void EditDevice(Device device, string name, string manufacturer, Device.DeviceType type, PortType portType)
        {
            device.Name = name;
            device.Manufacturer = manufacturer;
            device.Type = type;
            device.PortType = portType;
        }

        //connecting/disconnecting devices
        public void ConnectDeviceToComputer(Device device, int computerIndex)
        {
            computers[computerIndex].ConnectDevice(device);

        }

        public void DisconnectDeviceFromComputer(int computerIndex, Device device)
        {
            computers[computerIndex].DisconnectDevice(device);
        }
    }
}

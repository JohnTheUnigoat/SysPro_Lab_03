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

        private SortedList<Device.DeviceType, int> availableDeviceCount;

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
                    sb.AppendFormat(":\t{0}/{1}", availableDeviceCount[key], totalDeviceCount[key]);

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
            availableDeviceCount = new SortedList<Device.DeviceType, int>();
        }
    }
}

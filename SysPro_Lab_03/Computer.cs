using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPro_Lab_03
{
    class Computer
    {
        private static int currentID = 0;

        public List<Device> devices { get; }

        private Dictionary<PortType, int> totalPorts;

        private Dictionary<PortType, int> availablePorts;

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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPro_Lab_03
{
    public partial class Form1 : Form
    {
        private DeviceManager manager;

        private BindingSource bsComputers;

        public Form1()
        {
            InitializeComponent();

            manager = new DeviceManager();

            Dictionary<PortType, int> dict = new Dictionary<PortType, int>()
            {
                [PortType.USB] = 5,
                [PortType.Micro_USB] = 24
            };

            manager.AddComputer(new Computer(dict));
            manager.AddComputer(new Computer(dict));
            manager.AddComputer(new Computer(dict));

            manager.AddDevice(new Device("G Pro Wireless", "Logitech", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Y Pro Wireless", "Logitech", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Omega Pro Wireless", "Logitech", Device.DeviceType.Mouse, PortType.USB));

            bsComputers = new BindingSource();

            bsComputers.DataSource = manager.Computers;

            cbComputers.DataSource = bsComputers;

            lbUnusedDevices.DataSource = manager.UnusedDevices;
            
            listBox2.DataBindings.Add("DataSource", bsComputers, "PortList");

            btConnect.Click += btConnectClick;
            cbComputers.SelectedIndexChanged += SelectedComputerChanged;
        }

        private void SelectedComputerChanged(object sender, EventArgs e)
        {
            lbSelectedComputerDevices.DataSource = (cbComputers.SelectedItem as Computer).Devices;
        }

        private void btConnectClick(object sender, EventArgs e)
        {
            manager.ConnectDeviceToComputer(lbUnusedDevices.SelectedItem as Device, bsComputers.Position);
            lbUnusedDevices.DataSource = manager.UnusedDevices;
            lbSelectedComputerDevices.DataSource = (bsComputers.Current as Computer).Devices;
        }
    }
}

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

        private BindingSource bsManager;
        private BindingSource bsComputers;

        private DeviceCreateEdit deviceCreateEditForm;

        public Form1()
        {
            InitializeComponent();

            deviceCreateEditForm = new DeviceCreateEdit();

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
            manager.AddDevice(new Device("Mamba", "Razer", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Rival 600", "SteelSeries", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Rival 600", "SteelSeries", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Rival 600", "SteelSeries", Device.DeviceType.Mouse, PortType.USB));
            manager.AddDevice(new Device("Rival 600", "SteelSeries", Device.DeviceType.Mouse, PortType.USB));

            bsManager = new BindingSource();
            bsComputers = new BindingSource();

            bsManager.DataSource = manager;
            bsComputers.DataSource = manager.Computers;

            cbComputers.DataSource = bsComputers;

            lbSelectedComputerPorts.DataBindings.Add("DataSource", bsComputers, "PortList");
            lbSelectedComputerDevices.DataBindings.Add("DataSource", bsComputers, "Devices");
            lbUnusedDevices.DataBindings.Add("DataSource", bsManager, "UnusedDevices");

            btConnect.Click += btConnectClick;
            btDisconnect.Click += btDisconnectClick;
            btAddDevice.Click += btAddDeviceClick;
            lbUnusedDevices.DoubleClick += DevicesDoubleClick;
            btDeleteDevice.Click += btDeleteDeviceCLick;
        }

        private void btDeleteDeviceCLick(object sender, EventArgs e)
        {
            if (lbUnusedDevices.SelectedItem == null)
                return;

            manager.RemoveDevice(lbUnusedDevices.SelectedItem as Device);
            bsManager.ResetBindings(false);
        }

        private void DevicesDoubleClick(object sender, EventArgs e)
        {
            if (lbUnusedDevices.SelectedItem == null)
                return;

            deviceCreateEditForm.SetEdit(lbUnusedDevices.SelectedItem as Device);
            deviceCreateEditForm.ShowDialog();

            bsManager.ResetBindings(false);
        }

        private void btAddDeviceClick(object sender, EventArgs e)
        {
            deviceCreateEditForm.SetCreate();

            if(deviceCreateEditForm.ShowDialog() == DialogResult.OK)
            {
                manager.AddDevice(deviceCreateEditForm.WorkingDevice);
                bsManager.ResetBindings(false);
            }
        }

        private void btConnectClick(object sender, EventArgs e)
        {
            if (lbUnusedDevices.SelectedItem == null)
                return;

            try { manager.ConnectDeviceToComputer(lbUnusedDevices.SelectedItem as Device, bsComputers.Position); }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error!");
            }
            bsComputers.ResetBindings(false);
            bsManager.ResetBindings(false);
        }

        private void btDisconnectClick(object sender, EventArgs e)
        {
            if (lbSelectedComputerDevices.SelectedItem == null)
                return;

            try { manager.DisconnectDeviceFromComputer(bsComputers.Position, lbSelectedComputerDevices.SelectedItem as Device); }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Error!");
            }
            bsComputers.ResetBindings(false);
            bsManager.ResetBindings(false);
        }
    }
}

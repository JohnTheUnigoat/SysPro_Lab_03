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
    public partial class DeviceCreateEdit : Form
    {
        private Device workingDevice;

        internal Device WorkingDevice {
            get
            {
                return workingDevice;
            }
            private set
            {
                workingDevice = value;

                if (workingDevice == null)
                {
                    tbName.Text = "";
                    tbManufacturer.Text = "";
                    cbDeviceType.SelectedItem = Device.DeviceType.Mouse;
                    cbPortType.SelectedItem = PortType.USB;
                }
                else
                {
                    tbName.Text = workingDevice.Name;
                    tbManufacturer.Text = workingDevice.Manufacturer;
                    cbDeviceType.SelectedItem = workingDevice.Type;
                    cbPortType.SelectedItem = workingDevice.PortType;
                }
            }
        }

        public DeviceCreateEdit()
        {
            InitializeComponent();

            cbDeviceType.DataSource = Enum.GetValues(typeof(Device.DeviceType));
            cbPortType.DataSource = Enum.GetValues(typeof(PortType));

            btCreateEdit.Click += btCreateEditClick;
        }

        private void btCreateEditClick(object sender, EventArgs e)
        {
            if(workingDevice == null)
                WorkingDevice = new Device(
                    tbName.Text,
                    tbManufacturer.Text,
                    (Device.DeviceType)cbDeviceType.SelectedItem,
                    (PortType)cbPortType.SelectedItem
                    );
            else
            {
                workingDevice.Name = tbName.Text;
                workingDevice.Manufacturer = tbManufacturer.Text;
                workingDevice.Type = (Device.DeviceType)cbDeviceType.SelectedItem;
                workingDevice.PortType = (PortType)cbPortType.SelectedItem;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public void SetCreate()
        {
            WorkingDevice = null;
            btCreateEdit.Text = "Add device";
        }

        internal void SetEdit(Device device)
        {
            WorkingDevice = device;
            btCreateEdit.Text = "Edit device";
        }
    }
}

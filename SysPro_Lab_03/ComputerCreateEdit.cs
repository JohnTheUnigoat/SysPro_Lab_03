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
    public partial class ComputerCreateEdit : Form
    {
        private List<PortInfoControl> portInfoControls;

        private Computer workingComputer;

        internal Computer WorkingComputer {
            get { return workingComputer; }
            private set
            {
                if (value == null)
                {
                    foreach(var port in portInfoControls)
                    {
                        port.updPortCount.Value = 0;
                        port.updPortCount.Minimum = 0;
                    }
                }
                else
                {
                    for(int i = 0; i < Program.portTypesCount; i++)
                    {
                        portInfoControls[i].updPortCount.Value = value.Ports[i].Total;
                        portInfoControls[i].updPortCount.Minimum = value.Ports[i].Occupied;
                    }
                }

                workingComputer = value;
            }
        }

        private List<int> ports;

        public ComputerCreateEdit()
        {
            InitializeComponent();

            portInfoControls = new List<PortInfoControl>(Program.portTypesCount);

            int top = 0;
            foreach (var value in Enum.GetValues(typeof(PortType)))
            {
                portInfoControls.Add(new PortInfoControl(pnlPorts, value.ToString(), top));
                top += 23;
            }

            ports = new List<int>(Program.portTypesCount);

            btOk.Click += btOkClick;
        }

        private void btOkClick(object sender, EventArgs e)
        {
            for (int i = 0; i < portInfoControls.Count; i++)
            {
                ports.Add((int)portInfoControls[i].updPortCount.Value);
            }

            if (WorkingComputer == null)
                workingComputer = new Computer(ports);
            else
                workingComputer.SetPortsCount(ports);

            DialogResult = DialogResult.OK;
            Close();
        }

        public void SetCreate()
        {
            WorkingComputer = null;

            lblID.Text = string.Format("ID: {0}", Computer.currentID);
            ports.Clear();
        }

        internal void SetEdit(Computer computer)
        {
            WorkingComputer = computer;

            lblID.Text = string.Format("ID: {0}", computer.ID);
            ports.Clear();
        }
    }

    class PortInfoControl
    {
        public Label lblPortType { get; set; }

        public NumericUpDown updPortCount { get; set; }

        public PortInfoControl(Control parent, string labelText, int top)
        {
            lblPortType = new Label();
            lblPortType.Left = 0;
            lblPortType.Top = top;
            lblPortType.Width = 60;
            lblPortType.Text = labelText;
            lblPortType.TextAlign = ContentAlignment.MiddleLeft;
            lblPortType.Parent = parent;

            updPortCount = new NumericUpDown();
            updPortCount.Left = 70;
            updPortCount.Top = top;
            updPortCount.Width = 70;
            updPortCount.Parent = parent;
        }
    }
}

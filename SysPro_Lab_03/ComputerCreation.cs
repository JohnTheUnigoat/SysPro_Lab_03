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
    public partial class ComputerCreation : Form
    {
        private List<PortInfoControl> portInfoControls;

        internal Computer CreatedComputer { get; private set; }

        private List<int> ports;

        public ComputerCreation()
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

            btOk.Click += OkClick;
        }

        private void OkClick(object sender, EventArgs e)
        {
            for(int i = 0; i < portInfoControls.Count; i++)
            {
                ports.Add((int)portInfoControls[i].updPortCount.Value);
            }

            CreatedComputer = new Computer(ports);

            DialogResult = DialogResult.OK;
            Close();
        }

        public void Reset()
        {
            lblFutureID.Text = String.Format("Future ID: {0}", Computer.currentID);
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

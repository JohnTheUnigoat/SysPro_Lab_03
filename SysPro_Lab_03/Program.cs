using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPro_Lab_03
{
    enum PortType { USB, COM, Micro_USB, PCIe, VGA, HDMI, RJ45, DisplayPort, TypeC }

    public static class Program
    {
        public const int SetPortExceptionKey = 1;

        public static int portTypesCount;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            portTypesCount = Enum.GetValues(typeof(PortType)).Length;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

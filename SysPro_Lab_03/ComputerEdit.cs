﻿using System;
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
    public partial class ComputerEdit : Form
    {
        internal Computer EditComputer { get; set; }

        public ComputerEdit()
        {
            InitializeComponent();
        }
    }
}

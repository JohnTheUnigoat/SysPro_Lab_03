namespace SysPro_Lab_03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEditComputer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddComputer = new System.Windows.Forms.Button();
            this.btDeleteComputer = new System.Windows.Forms.Button();
            this.cbComputers = new System.Windows.Forms.ComboBox();
            this.lbSelectedComputerPorts = new System.Windows.Forms.ListBox();
            this.lbSelectedComputerDevices = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDeleteDevice = new System.Windows.Forms.Button();
            this.btAddDevice = new System.Windows.Forms.Button();
            this.lbUnusedDevices = new System.Windows.Forms.ListBox();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEditComputer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAddComputer);
            this.groupBox1.Controls.Add(this.btDeleteComputer);
            this.groupBox1.Controls.Add(this.cbComputers);
            this.groupBox1.Controls.Add(this.lbSelectedComputerPorts);
            this.groupBox1.Controls.Add(this.lbSelectedComputerDevices);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.btEditComputer.Location = new System.Drawing.Point(175, 15);
            this.btEditComputer.Name = "button7";
            this.btEditComputer.Size = new System.Drawing.Size(62, 38);
            this.btEditComputer.TabIndex = 8;
            this.btEditComputer.Text = "Edit";
            this.btEditComputer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computers: N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ports";
            // 
            // button1
            // 
            this.btAddComputer.Location = new System.Drawing.Point(104, 15);
            this.btAddComputer.Name = "button1";
            this.btAddComputer.Size = new System.Drawing.Size(62, 38);
            this.btAddComputer.TabIndex = 5;
            this.btAddComputer.Text = "New";
            this.btAddComputer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.btDeleteComputer.Location = new System.Drawing.Point(245, 15);
            this.btDeleteComputer.Name = "button2";
            this.btDeleteComputer.Size = new System.Drawing.Size(62, 38);
            this.btDeleteComputer.TabIndex = 4;
            this.btDeleteComputer.Text = "Delete";
            this.btDeleteComputer.UseVisualStyleBackColor = true;
            // 
            // cbComputers
            // 
            this.cbComputers.FormattingEnabled = true;
            this.cbComputers.Location = new System.Drawing.Point(6, 27);
            this.cbComputers.Name = "cbComputers";
            this.cbComputers.Size = new System.Drawing.Size(88, 26);
            this.cbComputers.TabIndex = 3;
            // 
            // lbSelectedComputerPorts
            // 
            this.lbSelectedComputerPorts.FormattingEnabled = true;
            this.lbSelectedComputerPorts.ItemHeight = 18;
            this.lbSelectedComputerPorts.Location = new System.Drawing.Point(6, 301);
            this.lbSelectedComputerPorts.Name = "lbSelectedComputerPorts";
            this.lbSelectedComputerPorts.Size = new System.Drawing.Size(301, 130);
            this.lbSelectedComputerPorts.TabIndex = 1;
            // 
            // lbSelectedComputerDevices
            // 
            this.lbSelectedComputerDevices.FormattingEnabled = true;
            this.lbSelectedComputerDevices.ItemHeight = 18;
            this.lbSelectedComputerDevices.Location = new System.Drawing.Point(6, 60);
            this.lbSelectedComputerDevices.Name = "lbSelectedComputerDevices";
            this.lbSelectedComputerDevices.Size = new System.Drawing.Size(301, 220);
            this.lbSelectedComputerDevices.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btDeleteDevice);
            this.groupBox2.Controls.Add(this.btAddDevice);
            this.groupBox2.Controls.Add(this.lbUnusedDevices);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(382, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unused Devices";
            // 
            // btDeleteDevice
            // 
            this.btDeleteDevice.Location = new System.Drawing.Point(171, 403);
            this.btDeleteDevice.Name = "btDeleteDevice";
            this.btDeleteDevice.Size = new System.Drawing.Size(147, 32);
            this.btDeleteDevice.TabIndex = 4;
            this.btDeleteDevice.Text = "Delete";
            this.btDeleteDevice.UseVisualStyleBackColor = true;
            // 
            // btAddDevice
            // 
            this.btAddDevice.Location = new System.Drawing.Point(6, 403);
            this.btAddDevice.Name = "btAddDevice";
            this.btAddDevice.Size = new System.Drawing.Size(159, 32);
            this.btAddDevice.TabIndex = 3;
            this.btAddDevice.Text = "Add";
            this.btAddDevice.UseVisualStyleBackColor = true;
            // 
            // lbUnusedDevices
            // 
            this.lbUnusedDevices.FormattingEnabled = true;
            this.lbUnusedDevices.ItemHeight = 18;
            this.lbUnusedDevices.Location = new System.Drawing.Point(6, 34);
            this.lbUnusedDevices.Name = "lbUnusedDevices";
            this.lbUnusedDevices.Size = new System.Drawing.Size(312, 364);
            this.lbUnusedDevices.TabIndex = 1;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDisconnect.Location = new System.Drawing.Point(332, 172);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(44, 27);
            this.btDisconnect.TabIndex = 5;
            this.btDisconnect.Text = ">";
            this.btDisconnect.UseVisualStyleBackColor = true;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btConnect.Location = new System.Drawing.Point(332, 139);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(44, 27);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "<";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddComputer;
        private System.Windows.Forms.Button btDeleteComputer;
        private System.Windows.Forms.ComboBox cbComputers;
        private System.Windows.Forms.ListBox lbSelectedComputerDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeleteDevice;
        private System.Windows.Forms.Button btAddDevice;
        private System.Windows.Forms.ListBox lbUnusedDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btEditComputer;
        private System.Windows.Forms.ListBox lbSelectedComputerPorts;
    }
}


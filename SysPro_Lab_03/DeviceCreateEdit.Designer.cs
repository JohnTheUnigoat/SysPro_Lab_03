namespace SysPro_Lab_03
{
    partial class DeviceCreateEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.cbPortType = new System.Windows.Forms.ComboBox();
            this.btCreateEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Device port";
            // 
            // NameTextBox
            // 
            this.tbName.Location = new System.Drawing.Point(114, 13);
            this.tbName.Name = "NameTextBox";
            this.tbName.Size = new System.Drawing.Size(144, 20);
            this.tbName.TabIndex = 4;
            // 
            // ManufacturerTextBox
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(114, 49);
            this.tbManufacturer.Name = "ManufacturerTextBox";
            this.tbManufacturer.Size = new System.Drawing.Size(144, 20);
            this.tbManufacturer.TabIndex = 5;
            // 
            // TypeComboBox
            // 
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Location = new System.Drawing.Point(114, 85);
            this.cbDeviceType.Name = "TypeComboBox";
            this.cbDeviceType.Size = new System.Drawing.Size(144, 21);
            this.cbDeviceType.TabIndex = 6;
            // 
            // PortComboBox
            // 
            this.cbPortType.FormattingEnabled = true;
            this.cbPortType.Location = new System.Drawing.Point(114, 122);
            this.cbPortType.Name = "PortComboBox";
            this.cbPortType.Size = new System.Drawing.Size(144, 21);
            this.cbPortType.TabIndex = 7;
            // 
            // button1
            // 
            this.btCreateEdit.Location = new System.Drawing.Point(12, 149);
            this.btCreateEdit.Name = "button1";
            this.btCreateEdit.Size = new System.Drawing.Size(246, 55);
            this.btCreateEdit.TabIndex = 8;
            this.btCreateEdit.UseVisualStyleBackColor = true;
            // 
            // DeviceCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 215);
            this.Controls.Add(this.btCreateEdit);
            this.Controls.Add(this.cbPortType);
            this.Controls.Add(this.cbDeviceType);
            this.Controls.Add(this.tbManufacturer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceCreateEdit";
            this.Text = "DeviceCreateEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.ComboBox cbPortType;
        private System.Windows.Forms.Button btCreateEdit;
    }
}
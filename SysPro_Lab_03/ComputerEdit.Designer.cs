namespace SysPro_Lab_03
{
    partial class ComputerEdit
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
            this.PortNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPorts = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNumeric
            // 
            this.PortNumeric.Location = new System.Drawing.Point(82, 195);
            this.PortNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.PortNumeric.Name = "PortNumeric";
            this.PortNumeric.Size = new System.Drawing.Size(49, 20);
            this.PortNumeric.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer ID: {0}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 225);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pnlPorts
            // 
            this.pnlPorts.AutoScroll = true;
            this.pnlPorts.Location = new System.Drawing.Point(6, 12);
            this.pnlPorts.Name = "pnlPorts";
            this.pnlPorts.Size = new System.Drawing.Size(147, 207);
            this.pnlPorts.TabIndex = 11;
            // 
            // ComputerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortNumeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerEdit";
            this.Text = "ComputerEdit";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown PortNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPorts;
    }
}
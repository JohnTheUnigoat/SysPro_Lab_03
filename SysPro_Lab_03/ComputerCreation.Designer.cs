namespace SysPro_Lab_03
{
    partial class ComputerCreation
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
            this.lblFutureID = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.pnlPorts = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFutureID
            // 
            this.lblFutureID.AutoSize = true;
            this.lblFutureID.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFutureID.Location = new System.Drawing.Point(13, 13);
            this.lblFutureID.Name = "lblFutureID";
            this.lblFutureID.Size = new System.Drawing.Size(88, 18);
            this.lblFutureID.TabIndex = 0;
            this.lblFutureID.Text = "Future ID: {0}";
            // 
            // OKButton
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(12, 266);
            this.btOk.Name = "OKButton";
            this.btOk.Size = new System.Drawing.Size(159, 44);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // pnlPorts
            // 
            this.pnlPorts.AutoScroll = true;
            this.pnlPorts.Location = new System.Drawing.Point(6, 12);
            this.pnlPorts.Name = "pnlPorts";
            this.pnlPorts.Size = new System.Drawing.Size(147, 207);
            this.pnlPorts.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlPorts);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 225);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // ComputerCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lblFutureID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerCreation";
            this.Text = "ComputerCreation";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFutureID;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel pnlPorts;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
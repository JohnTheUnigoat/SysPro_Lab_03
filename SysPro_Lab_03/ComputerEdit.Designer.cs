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
            this.label1 = new System.Windows.Forms.Label();
            this.PortNumeric = new System.Windows.Forms.NumericUpDown();
            this.PortGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port count:";
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
            // PortGridView
            // 
            this.PortGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortGridView.Location = new System.Drawing.Point(12, 36);
            this.PortGridView.Name = "PortGridView";
            this.PortGridView.Size = new System.Drawing.Size(182, 150);
            this.PortGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer ID:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // ComputerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 226);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortGridView);
            this.Controls.Add(this.PortNumeric);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComputerEdit";
            this.Text = "ComputerEdit";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PortNumeric;
        private System.Windows.Forms.DataGridView PortGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
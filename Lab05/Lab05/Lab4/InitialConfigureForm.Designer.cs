namespace Lab4
{
    partial class InitialConfigureForm
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
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BaudUpDown = new System.Windows.Forms.NumericUpDown();
            this.StopUpDown = new System.Windows.Forms.NumericUpDown();
            this.DataBitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaudUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBitsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(0, 9);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(55, 13);
            this.BaudRateLabel.TabIndex = 0;
            this.BaudRateLabel.Text = "BaudRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DataBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FlowControl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Parity";
            // 
            // BaudUpDown
            // 
            this.BaudUpDown.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.BaudUpDown.Location = new System.Drawing.Point(62, 9);
            this.BaudUpDown.Maximum = new decimal(new int[] {
            921600,
            0,
            0,
            0});
            this.BaudUpDown.Name = "BaudUpDown";
            this.BaudUpDown.Size = new System.Drawing.Size(120, 20);
            this.BaudUpDown.TabIndex = 4;
            this.BaudUpDown.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // StopUpDown
            // 
            this.StopUpDown.DecimalPlaces = 1;
            this.StopUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.StopUpDown.Location = new System.Drawing.Point(62, 36);
            this.StopUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.StopUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StopUpDown.Name = "StopUpDown";
            this.StopUpDown.Size = new System.Drawing.Size(120, 20);
            this.StopUpDown.TabIndex = 5;
            this.StopUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DataBitsUpDown
            // 
            this.DataBitsUpDown.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DataBitsUpDown.Location = new System.Drawing.Point(62, 92);
            this.DataBitsUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.DataBitsUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DataBitsUpDown.Name = "DataBitsUpDown";
            this.DataBitsUpDown.Size = new System.Drawing.Size(120, 20);
            this.DataBitsUpDown.TabIndex = 6;
            this.DataBitsUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "None";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(3, 157);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 9;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "None";
            // 
            // InitialConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBitsUpDown);
            this.Controls.Add(this.StopUpDown);
            this.Controls.Add(this.BaudUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaudRateLabel);
            this.Name = "InitialConfigureForm";
            this.Text = "Configure Tab";
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaudUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBitsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BaudUpDown;
        private System.Windows.Forms.NumericUpDown StopUpDown;
        private System.Windows.Forms.NumericUpDown DataBitsUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label1;
    }
}
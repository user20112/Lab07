namespace Lab07_Client
{
    partial class Configure
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_com = new System.Windows.Forms.ComboBox();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.cb_stopBits = new System.Windows.Forms.ComboBox();
            this.cb_baudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "COM Port:";
            // 
            // cb_com
            // 
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Location = new System.Drawing.Point(162, 33);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(171, 33);
            this.cb_com.TabIndex = 30;
            // 
            // cb_parity
            // 
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(162, 225);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(171, 33);
            this.cb_parity.TabIndex = 29;
            // 
            // cb_stopBits
            // 
            this.cb_stopBits.FormattingEnabled = true;
            this.cb_stopBits.Location = new System.Drawing.Point(162, 161);
            this.cb_stopBits.Name = "cb_stopBits";
            this.cb_stopBits.Size = new System.Drawing.Size(171, 33);
            this.cb_stopBits.TabIndex = 28;
            // 
            // cb_baudRate
            // 
            this.cb_baudRate.FormattingEnabled = true;
            this.cb_baudRate.Location = new System.Drawing.Point(162, 97);
            this.cb_baudRate.Name = "cb_baudRate";
            this.cb_baudRate.Size = new System.Drawing.Size(171, 33);
            this.cb_baudRate.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Parity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Stop Bits:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Baud Rate:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(17, 302);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(165, 50);
            this.btn_Submit.TabIndex = 32;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(201, 302);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(165, 50);
            this.btn_Cancel.TabIndex = 33;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 373);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_com);
            this.Controls.Add(this.cb_parity);
            this.Controls.Add(this.cb_stopBits);
            this.Controls.Add(this.cb_baudRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 444);
            this.Name = "Configure";
            this.ShowIcon = false;
            this.Text = "Configure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_com;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.ComboBox cb_stopBits;
        private System.Windows.Forms.ComboBox cb_baudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
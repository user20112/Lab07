namespace Lab4
{
    partial class PortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ConfigurePortButton = new System.Windows.Forms.ToolStripButton();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.AsciiBox = new System.Windows.Forms.TextBox();
            this.HexBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AsciiLabel = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurePortButton,
            this.StartButton,
            this.StopButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(346, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ConfigurePortButton
            // 
            this.ConfigurePortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConfigurePortButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfigurePortButton.Image")));
            this.ConfigurePortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConfigurePortButton.Name = "ConfigurePortButton";
            this.ConfigurePortButton.Size = new System.Drawing.Size(86, 22);
            this.ConfigurePortButton.Text = "ConfigurePort";
            this.ConfigurePortButton.ToolTipText = "ConfigurePort";
            this.ConfigurePortButton.Click += new System.EventHandler(this.ConfigurePortButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(35, 22);
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(35, 22);
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AsciiBox
            // 
            this.AsciiBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AsciiBox.Location = new System.Drawing.Point(12, 86);
            this.AsciiBox.Multiline = true;
            this.AsciiBox.Name = "AsciiBox";
            this.AsciiBox.ReadOnly = true;
            this.AsciiBox.Size = new System.Drawing.Size(160, 318);
            this.AsciiBox.TabIndex = 2;
            // 
            // HexBox
            // 
            this.HexBox.Location = new System.Drawing.Point(178, 86);
            this.HexBox.Multiline = true;
            this.HexBox.Name = "HexBox";
            this.HexBox.ReadOnly = true;
            this.HexBox.Size = new System.Drawing.Size(156, 318);
            this.HexBox.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 410);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(322, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear Data Recieved";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AsciiLabel
            // 
            this.AsciiLabel.AutoSize = true;
            this.AsciiLabel.Location = new System.Drawing.Point(12, 67);
            this.AsciiLabel.Name = "AsciiLabel";
            this.AsciiLabel.Size = new System.Drawing.Size(34, 13);
            this.AsciiLabel.TabIndex = 9;
            this.AsciiLabel.Text = "Temp";
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Location = new System.Drawing.Point(179, 67);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(34, 13);
            this.HexLabel.TabIndex = 10;
            this.HexLabel.Text = "Temp";
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.AsciiLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.HexBox);
            this.Controls.Add(this.AsciiBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PortForm";
            this.Text = "Port Tab";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.TextBox AsciiBox;
        private System.Windows.Forms.TextBox HexBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label AsciiLabel;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.ToolStripButton ConfigurePortButton;
    }
}
namespace Lab4
{
    partial class StartupForm
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
            this.PortListView = new System.Windows.Forms.ListView();
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // PortListView
            // 
            this.PortListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CName,
            this.PortName,
            this.OpenClose});
            this.PortListView.Location = new System.Drawing.Point(12, 12);
            this.PortListView.Name = "PortListView";
            this.PortListView.Size = new System.Drawing.Size(250, 191);
            this.PortListView.TabIndex = 1;
            this.PortListView.UseCompatibleStateImageBehavior = false;
            // 
            // CName
            // 
            this.CName.Text = "Name";
            this.CName.Width = -2;
            // 
            // PortName
            // 
            this.PortName.Text = "PortName";
            this.PortName.Width = -2;
            // 
            // OpenClose
            // 
            this.OpenClose.Text = "Open/Closed";
            this.OpenClose.Width = -2;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 215);
            this.Controls.Add(this.PortListView);
            this.Name = "StartupForm";
            this.Text = "Serial Sniffer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView PortListView;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.ColumnHeader PortName;
        private System.Windows.Forms.ColumnHeader OpenClose;
    }
}


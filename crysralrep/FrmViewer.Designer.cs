namespace crysralrep
{
    partial class FrmViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewer));
            this.CrViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrViewer
            // 
            this.CrViewer.ActiveViewIndex = -1;
            this.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrViewer.Location = new System.Drawing.Point(0, 0);
            this.CrViewer.Name = "CrViewer";
            this.CrViewer.Size = new System.Drawing.Size(1205, 587);
            this.CrViewer.TabIndex = 0;
            // 
            // FrmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 587);
            this.Controls.Add(this.CrViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewer";
            this.Text = "View Course Details";
            this.Load += new System.EventHandler(this.FrmViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer;
    }
}
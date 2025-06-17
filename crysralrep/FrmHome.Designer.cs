namespace crysralrep
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::crysralrep.Properties.Resources.document_4904201;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::crysralrep.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::crysralrep.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.removeStudentToolStripMenuItem});
            this.manageToolStripMenuItem.Image = global::crysralrep.Properties.Resources.tools_600604;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Image = global::crysralrep.Properties.Resources.student;
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newStudentToolStripMenuItem.Text = "Students";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click_1);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.Image = global::crysralrep.Properties.Resources.lecturer;
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeStudentToolStripMenuItem.Text = "Lecturers";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileReportToolStripMenuItem,
            this.markSheetToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::crysralrep.Properties.Resources.course1;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // profileReportToolStripMenuItem
            // 
            this.profileReportToolStripMenuItem.Image = global::crysralrep.Properties.Resources.course_icon;
            this.profileReportToolStripMenuItem.Name = "profileReportToolStripMenuItem";
            this.profileReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileReportToolStripMenuItem.Text = "Courses";
            this.profileReportToolStripMenuItem.Click += new System.EventHandler(this.profileReportToolStripMenuItem_Click_1);
            // 
            // markSheetToolStripMenuItem
            // 
            this.markSheetToolStripMenuItem.Image = global::crysralrep.Properties.Resources.results;
            this.markSheetToolStripMenuItem.Name = "markSheetToolStripMenuItem";
            this.markSheetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.markSheetToolStripMenuItem.Text = "Mark Sheet";
            this.markSheetToolStripMenuItem.Click += new System.EventHandler(this.markSheetToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crysralrep.Properties.Resources.student_management_system;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 657);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markSheetToolStripMenuItem;
    }
}
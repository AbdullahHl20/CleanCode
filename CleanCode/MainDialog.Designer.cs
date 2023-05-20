
namespace CleanCode
{
    partial class MainDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            this.ID_StatusBar = new System.Windows.Forms.StatusStrip();
            this.ID_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ID_Home = new DevExpress.XtraEditors.SimpleButton();
            this.ID_Users = new DevExpress.XtraEditors.SimpleButton();
            this.ID_Student = new DevExpress.XtraEditors.SimpleButton();
            this.ID_Setteings = new DevExpress.XtraEditors.SimpleButton();
            this.ID_BtnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.ID_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.panelContener = new System.Windows.Forms.Panel();
            this.ID_StatusBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_StatusBar
            // 
            this.ID_StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ID_StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ID_StatusLabel,
            this.ID_ProgressBar});
            this.ID_StatusBar.Location = new System.Drawing.Point(0, 655);
            this.ID_StatusBar.Name = "ID_StatusBar";
            this.ID_StatusBar.Size = new System.Drawing.Size(1178, 34);
            this.ID_StatusBar.TabIndex = 1;
            this.ID_StatusBar.Text = "statusStrip1";
            // 
            // ID_StatusLabel
            // 
            this.ID_StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ID_StatusLabel.Name = "ID_StatusLabel";
            this.ID_StatusLabel.Size = new System.Drawing.Size(199, 28);
            this.ID_StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // ID_ProgressBar
            // 
            this.ID_ProgressBar.Name = "ID_ProgressBar";
            this.ID_ProgressBar.Size = new System.Drawing.Size(200, 26);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ID_Home);
            this.flowLayoutPanel1.Controls.Add(this.ID_Users);
            this.flowLayoutPanel1.Controls.Add(this.ID_Student);
            this.flowLayoutPanel1.Controls.Add(this.ID_Setteings);
            this.flowLayoutPanel1.Controls.Add(this.ID_BtnHelp);
            this.flowLayoutPanel1.Controls.Add(this.ID_Exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1178, 80);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ID_Home
            // 
            this.ID_Home.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_Home.Appearance.Options.UseFont = true;
            this.ID_Home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ID_Home.ImageOptions.SvgImage")));
            this.ID_Home.Location = new System.Drawing.Point(3, 3);
            this.ID_Home.Name = "ID_Home";
            this.ID_Home.Padding = new System.Windows.Forms.Padding(5);
            this.ID_Home.Size = new System.Drawing.Size(164, 66);
            this.ID_Home.TabIndex = 0;
            this.ID_Home.Text = "Home";
            this.ID_Home.Click += new System.EventHandler(this.ID_Home_Click);
            // 
            // ID_Users
            // 
            this.ID_Users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_Users.Appearance.Options.UseFont = true;
            this.ID_Users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ID_Users.ImageOptions.SvgImage")));
            this.ID_Users.Location = new System.Drawing.Point(173, 3);
            this.ID_Users.Name = "ID_Users";
            this.ID_Users.Padding = new System.Windows.Forms.Padding(5);
            this.ID_Users.Size = new System.Drawing.Size(164, 66);
            this.ID_Users.TabIndex = 1;
            this.ID_Users.Text = "Users";
            this.ID_Users.Click += new System.EventHandler(this.ID_Users_Click);
            // 
            // ID_Student
            // 
            this.ID_Student.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_Student.Appearance.Options.UseFont = true;
            this.ID_Student.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ID_Student.ImageOptions.SvgImage")));
            this.ID_Student.Location = new System.Drawing.Point(343, 3);
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Padding = new System.Windows.Forms.Padding(5);
            this.ID_Student.Size = new System.Drawing.Size(164, 66);
            this.ID_Student.TabIndex = 2;
            this.ID_Student.Text = "Student";
            this.ID_Student.Click += new System.EventHandler(this.ID_Student_Click);
            // 
            // ID_Setteings
            // 
            this.ID_Setteings.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_Setteings.Appearance.Options.UseFont = true;
            this.ID_Setteings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ID_Setteings.ImageOptions.SvgImage")));
            this.ID_Setteings.Location = new System.Drawing.Point(513, 3);
            this.ID_Setteings.Name = "ID_Setteings";
            this.ID_Setteings.Padding = new System.Windows.Forms.Padding(5);
            this.ID_Setteings.Size = new System.Drawing.Size(164, 66);
            this.ID_Setteings.TabIndex = 3;
            this.ID_Setteings.Text = "Setteings";
            this.ID_Setteings.Click += new System.EventHandler(this.ID_Setteings_Click);
            // 
            // ID_BtnHelp
            // 
            this.ID_BtnHelp.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_BtnHelp.Appearance.Options.UseFont = true;
            this.ID_BtnHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ID_BtnHelp.ImageOptions.SvgImage")));
            this.ID_BtnHelp.Location = new System.Drawing.Point(683, 3);
            this.ID_BtnHelp.Name = "ID_BtnHelp";
            this.ID_BtnHelp.Padding = new System.Windows.Forms.Padding(5);
            this.ID_BtnHelp.Size = new System.Drawing.Size(164, 66);
            this.ID_BtnHelp.TabIndex = 4;
            this.ID_BtnHelp.Text = "Help";
            this.ID_BtnHelp.Click += new System.EventHandler(this.ID_BtnHelp_Click);
            // 
            // ID_Exit
            // 
            this.ID_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_Exit.Appearance.Options.UseFont = true;
            this.ID_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ID_Exit.ImageOptions.Image")));
            this.ID_Exit.Location = new System.Drawing.Point(853, 3);
            this.ID_Exit.Name = "ID_Exit";
            this.ID_Exit.Padding = new System.Windows.Forms.Padding(5);
            this.ID_Exit.Size = new System.Drawing.Size(164, 66);
            this.ID_Exit.TabIndex = 5;
            this.ID_Exit.Text = "Exit";
            this.ID_Exit.Click += new System.EventHandler(this.ID_Exit_Click);
            // 
            // panelContener
            // 
            this.panelContener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContener.Location = new System.Drawing.Point(0, 80);
            this.panelContener.Name = "panelContener";
            this.panelContener.Size = new System.Drawing.Size(1178, 575);
            this.panelContener.TabIndex = 3;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 689);
            this.Controls.Add(this.panelContener);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ID_StatusBar);
            this.Name = "MainDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleanCode";
            this.Load += new System.EventHandler(this.MainDialog_Load);
            this.ID_StatusBar.ResumeLayout(false);
            this.ID_StatusBar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ID_StatusBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton ID_Home;
        private DevExpress.XtraEditors.SimpleButton ID_Users;
        private DevExpress.XtraEditors.SimpleButton ID_Student;
        private DevExpress.XtraEditors.SimpleButton ID_Setteings;
        private DevExpress.XtraEditors.SimpleButton ID_BtnHelp;
        private System.Windows.Forms.ToolStripStatusLabel ID_StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ID_ProgressBar;
        private DevExpress.XtraEditors.SimpleButton ID_Exit;
        public System.Windows.Forms.Panel panelContener;
    }
}


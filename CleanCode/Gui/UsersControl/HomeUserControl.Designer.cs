
namespace CleanCode.Gui.UsersControl
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompanyLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CleanCode.Properties.Resources.ASUS;
            this.pictureBox1.Location = new System.Drawing.Point(3, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CompanyLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(345, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 355);
            this.panel1.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.CompanyLabel.Appearance.Options.UseFont = true;
            this.CompanyLabel.Location = new System.Drawing.Point(3, 274);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(94, 48);
            this.CompanyLabel.TabIndex = 1;
            this.CompanyLabel.Text = "ASUS";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 512);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 48);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "11:30 AM";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1217, 576);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl CompanyLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

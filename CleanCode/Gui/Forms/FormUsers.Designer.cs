
namespace CleanCode.Gui.Forms
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_BtnImport = new DevExpress.XtraEditors.SimpleButton();
            this.ID_PictureBox = new System.Windows.Forms.PictureBox();
            this.ID_ComboBoxRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ID_BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ID_TxtPssword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ID_TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ID_TxtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ID_TxtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_ComboBoxRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtPssword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 615);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID_BtnImport);
            this.groupBox1.Controls.Add(this.ID_PictureBox);
            this.groupBox1.Controls.Add(this.ID_ComboBoxRole);
            this.groupBox1.Controls.Add(this.ID_BtnSave);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.ID_TxtPssword);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.ID_TxtUserName);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.ID_TxtLastName);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.ID_TxtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 600);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // ID_BtnImport
            // 
            this.ID_BtnImport.Location = new System.Drawing.Point(489, 366);
            this.ID_BtnImport.Name = "ID_BtnImport";
            this.ID_BtnImport.Size = new System.Drawing.Size(477, 66);
            this.ID_BtnImport.TabIndex = 14;
            this.ID_BtnImport.Text = "Import";
            this.ID_BtnImport.Click += new System.EventHandler(this.ID_BtnImport_Click);
            // 
            // ID_PictureBox
            // 
            this.ID_PictureBox.Image = global::CleanCode.Properties.Resources.Screenshot__1_;
            this.ID_PictureBox.Location = new System.Drawing.Point(489, 47);
            this.ID_PictureBox.Name = "ID_PictureBox";
            this.ID_PictureBox.Size = new System.Drawing.Size(477, 313);
            this.ID_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ID_PictureBox.TabIndex = 13;
            this.ID_PictureBox.TabStop = false;
            // 
            // ID_ComboBoxRole
            // 
            this.ID_ComboBoxRole.Location = new System.Drawing.Point(19, 434);
            this.ID_ComboBoxRole.Name = "ID_ComboBoxRole";
            this.ID_ComboBoxRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ID_ComboBoxRole.Properties.Appearance.Options.UseFont = true;
            this.ID_ComboBoxRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_ComboBoxRole.Size = new System.Drawing.Size(331, 30);
            this.ID_ComboBoxRole.TabIndex = 12;
            // 
            // ID_BtnSave
            // 
            this.ID_BtnSave.Location = new System.Drawing.Point(819, 492);
            this.ID_BtnSave.Name = "ID_BtnSave";
            this.ID_BtnSave.Size = new System.Drawing.Size(147, 66);
            this.ID_BtnSave.TabIndex = 11;
            this.ID_BtnSave.Text = "Add";
            this.ID_BtnSave.Click += new System.EventHandler(this.ID_BtnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "FirstName";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "LastName";
            // 
            // ID_TxtPssword
            // 
            this.ID_TxtPssword.Location = new System.Drawing.Point(19, 348);
            this.ID_TxtPssword.Name = "ID_TxtPssword";
            this.ID_TxtPssword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ID_TxtPssword.Properties.Appearance.Options.UseFont = true;
            this.ID_TxtPssword.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ID_TxtPssword.Properties.ContextImageOptions.Image")));
            this.ID_TxtPssword.Properties.PasswordChar = '*';
            this.ID_TxtPssword.Size = new System.Drawing.Size(331, 36);
            this.ID_TxtPssword.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 243);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "UserName";
            // 
            // ID_TxtUserName
            // 
            this.ID_TxtUserName.Location = new System.Drawing.Point(19, 273);
            this.ID_TxtUserName.Name = "ID_TxtUserName";
            this.ID_TxtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ID_TxtUserName.Properties.Appearance.Options.UseFont = true;
            this.ID_TxtUserName.Size = new System.Drawing.Size(331, 34);
            this.ID_TxtUserName.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 318);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Password";
            // 
            // ID_TxtLastName
            // 
            this.ID_TxtLastName.Location = new System.Drawing.Point(19, 182);
            this.ID_TxtLastName.Name = "ID_TxtLastName";
            this.ID_TxtLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ID_TxtLastName.Properties.Appearance.Options.UseFont = true;
            this.ID_TxtLastName.Size = new System.Drawing.Size(331, 34);
            this.ID_TxtLastName.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 404);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 24);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "UserRole";
            // 
            // ID_TxtFirstName
            // 
            this.ID_TxtFirstName.Location = new System.Drawing.Point(19, 87);
            this.ID_TxtFirstName.Name = "ID_TxtFirstName";
            this.ID_TxtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ID_TxtFirstName.Properties.Appearance.Options.UseFont = true;
            this.ID_TxtFirstName.Size = new System.Drawing.Size(331, 34);
            this.ID_TxtFirstName.TabIndex = 6;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 615);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormUsers";
            this.ShowIcon = false;
            this.Text = "FormUsers";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_ComboBoxRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtPssword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TxtFirstName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ID_TxtFirstName;
        private DevExpress.XtraEditors.TextEdit ID_TxtPssword;
        private DevExpress.XtraEditors.TextEdit ID_TxtUserName;
        private DevExpress.XtraEditors.TextEdit ID_TxtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton ID_BtnImport;
        private System.Windows.Forms.PictureBox ID_PictureBox;
        private DevExpress.XtraEditors.ComboBoxEdit ID_ComboBoxRole;
        public DevExpress.XtraEditors.SimpleButton ID_BtnSave;
    }
}
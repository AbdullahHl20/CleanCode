
namespace CleanCode.Gui.UsersControl
{
    partial class UsersPageUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPageUserControl));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ID_BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemAlignment1 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserLogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.ID_BtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(920, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.textEdit1);
            this.panel2.Location = new System.Drawing.Point(474, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 50);
            this.panel2.TabIndex = 4;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(319, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(107, 44);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Serach";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(3, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(307, 42);
            this.textEdit1.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(322, 32);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(146, 50);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Delete";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(170, 32);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(146, 50);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Edit";
            // 
            // ID_BtnAdd
            // 
            this.ID_BtnAdd.Location = new System.Drawing.Point(18, 32);
            this.ID_BtnAdd.Name = "ID_BtnAdd";
            this.ID_BtnAdd.Size = new System.Drawing.Size(146, 50);
            this.ID_BtnAdd.TabIndex = 0;
            this.ID_BtnAdd.Text = "Add";
            this.ID_BtnAdd.Click += new System.EventHandler(this.ID_BtnAdd_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFirstName,
            this.colLastName,
            this.colUserName,
            this.colUserPassword,
            this.colUserRole,
            this.colUserLogo,
            this.colAddedDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SynchronizeClones = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colId
            // 
            this.colId.ColumnEdit = this.repositoryItemAlignment1;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // repositoryItemAlignment1
            // 
            this.repositoryItemAlignment1.AutoHeight = false;
            this.repositoryItemAlignment1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAlignment1.HasArabic = false;
            this.repositoryItemAlignment1.HasDistribute = false;
            this.repositoryItemAlignment1.HasThaiDistribute = false;
            this.repositoryItemAlignment1.Name = "repositoryItemAlignment1";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "اسم ";
            this.colFirstName.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 25;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            this.colFirstName.Width = 94;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "الكنية";
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 25;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "اسم المستخدم";
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 94;
            // 
            // colUserPassword
            // 
            this.colUserPassword.Caption = "كلمة المرور";
            this.colUserPassword.FieldName = "UserPassword";
            this.colUserPassword.MinWidth = 25;
            this.colUserPassword.Name = "colUserPassword";
            this.colUserPassword.Visible = true;
            this.colUserPassword.VisibleIndex = 3;
            this.colUserPassword.Width = 94;
            // 
            // colUserRole
            // 
            this.colUserRole.Caption = "الصلاحية";
            this.colUserRole.FieldName = "UserRole";
            this.colUserRole.MinWidth = 25;
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.Visible = true;
            this.colUserRole.VisibleIndex = 4;
            this.colUserRole.Width = 94;
            // 
            // colUserLogo
            // 
            this.colUserLogo.Caption = "الصورة";
            this.colUserLogo.FieldName = "UserLogo";
            this.colUserLogo.MinWidth = 25;
            this.colUserLogo.Name = "colUserLogo";
            this.colUserLogo.Visible = true;
            this.colUserLogo.VisibleIndex = 5;
            this.colUserLogo.Width = 94;
            // 
            // colAddedDate
            // 
            this.colAddedDate.Caption = "تاريخ الأضافة";
            this.colAddedDate.FieldName = "AddedDate";
            this.colAddedDate.MinWidth = 25;
            this.colAddedDate.Name = "colAddedDate";
            this.colAddedDate.Visible = true;
            this.colAddedDate.VisibleIndex = 6;
            this.colAddedDate.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "UserTable";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(18, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAlignment1,
            this.repositoryItemRichTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(882, 426);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "CleanCode.Properties.Settings.StudentConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            allColumns2.Table = null;
            selectQuery2.Columns.Add(allColumns2);
            selectQuery2.Name = "UserTable";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"225\" />";
            table2.Name = "UserTable";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // UsersPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "UsersPageUserControl";
            this.Size = new System.Drawing.Size(920, 581);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAlignment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton ID_BtnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colUserLogo;
        private DevExpress.XtraGrid.Columns.GridColumn colAddedDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}

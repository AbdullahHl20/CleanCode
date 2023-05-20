using CleanCode.Code;
using CleanCode.DataBase.SqlServer.EFModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CleanCode.Gui.UsersControl;

namespace CleanCode.Gui.Forms
{
    public partial class FormUsers : Form
    {
        int  _id;
        object[] param;
        FileSystem fileSystem;
        UsersPageUserControl usersPageUserCo;
        private IdataHelper<UserTable> usertableControlor;


        public FormUsers(int Id, UsersPageUserControl usersPageUserControl)
        {
            InitializeComponent();
            fileSystem           = new FileSystem();
            usertableControlor   = new UsersControler();
            usersPageUserCo = usersPageUserControl;
            this._id = Id;
            ID_ComboBoxRole.AppendText("ADDmin");
        }

        private void ID_BtnImport_Click(object sender, EventArgs e)
        {
           ID_PictureBox.Image=Image.FromFile ( fileSystem.GetImageFile());
        }

        private void ID_BtnSave_Click(object sender, EventArgs e)
        {
            //Check Input

            if (_id == 0) 
            {
                param = new object[6];
                param[0] = ID_TxtFirstName.Text;
                param[1] = ID_TxtLastName.Text;
                param[2] = ID_TxtUserName.Text;
                param[3] = ID_TxtPssword.Text;
                param[4] = ID_ComboBoxRole.SelectedItem;
                param[5] = fileSystem.ConvertImageToByte(ID_PictureBox.Image);
               
                 usertableControlor.Adddata(param);
                MessageBox.Show(Properties.Resources.IDS_AddDone  );
                usersPageUserCo.UpdateGridView();
            }
          
            //_dbstudentEntities.UserTables.Add(userTable);
            //_dbstudentEntities.SaveChanges();
        }
    }
}

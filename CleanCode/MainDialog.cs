using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CleanCode.Code;
using CleanCode.Gui.UsersControl;
using CleanCode.Gui.Forms;

namespace CleanCode
{
    public partial class MainDialog : Form
    {
        private MainPageControllr _mainPageControllr;
        public MainDialog()
        {
            InitializeComponent();
            _mainPageControllr = new MainPageControllr(this);
        }


        #region Events
        private void MainDialog_Load(object sender, EventArgs e)
        {
            _mainPageControllr.LoadPage(new HomeUserControl());
        }
        private void ID_Home_Click(object sender, EventArgs e)
        {       
            _mainPageControllr.LoadPage(new HomeUserControl());
        }
        private void ID_Users_Click(object sender, EventArgs e)
        {
            _mainPageControllr.LoadPage(new UsersPageUserControl());
        }
        private void ID_Student_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            addNewStudent.Show();
           
        }
        private void ID_Setteings_Click(object sender, EventArgs e)
        {

        }
        private void ID_BtnHelp_Click(object sender, EventArgs e)
        {

        }
        private void ID_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

      
    }
}

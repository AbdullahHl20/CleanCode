using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.Gui.UsersControl;
using System.Windows.Forms;
using System.Drawing;

namespace CleanCode.Code
{
  public class MainPageControllr
    {

        private MainDialog _main;

        public MainPageControllr(MainDialog main) 
        {
            _main = main;
        }

        public void LoadPage(UserControl userControl) 
        {
            //  DisposeOldPage
            var OldPage = _main.panelContener.Controls.OfType<HomeUserControl>().SingleOrDefault();
            if (OldPage != null)
            {
                _main.panelContener.Controls.Clear();
                OldPage.Dispose();
            }
            //Load New Page

            userControl.Dock = DockStyle.Fill;
            _main.panelContener.Controls.Add(userControl);
        }

       

    }
}

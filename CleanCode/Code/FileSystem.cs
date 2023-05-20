using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;


namespace CleanCode.Code
{
    public class FileSystem
    {
        static string _fileName;
        public string GetImageFile()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Logo";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "jpg file |*.jpg";
            var result = openFileDialog.ShowDialog();
            //Check Dialog
            if (result == DialogResult.OK)
            {
                _fileName = openFileDialog.FileName;
            }

            return _fileName;

        }

        public byte[] ConvertImageToByte(Image image)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                image.Save(memory,ImageFormat.Jpeg);
                return memory.ToArray();
            };

            
        }
    }
}

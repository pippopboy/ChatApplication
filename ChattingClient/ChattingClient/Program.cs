using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChattingClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
         //OpenFileDialog openFileDialog = new OpenFileDialog();
         //   openFileDialog.Filter = "image file (*.png)|*.png|(*.jpg)|*.jpg|(*.gif)|*.gif";
         //   openFileDialog.ShowDialog();
         //   string newpath = Path.Combine(@"D:\Study", Path.GetFileName(openFileDialog.FileName));
         //   pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
         //   if (File.Exists(newpath))
         //   {
         //       MessageBox.Show("That image exists");
         //   }
         //   else
         //   {
         //       File.Copy(openFileDialog.FileName,newpath);
         //   }
    }
}

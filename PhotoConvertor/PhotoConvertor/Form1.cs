using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
        }

        Image OriginPicture;
        

        private void btn_choosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePicture = new OpenFileDialog();

            choosePicture.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (choosePicture.ShowDialog() == DialogResult.OK)
            {
                OriginPicture = new Bitmap(choosePicture.OpenFile());
                pb_Original.Image = OriginPicture;
            }
        }
    }
}

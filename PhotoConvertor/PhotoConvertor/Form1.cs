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

        Bitmap OriginPicture;
        Bitmap SolutiunPicture;
        double multiplyer;

        private void btn_choosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePicture = new OpenFileDialog();

            choosePicture.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (choosePicture.ShowDialog() == DialogResult.OK)
            {
                OriginPicture = new Bitmap(choosePicture.OpenFile()); 
                
                pb_Original.Width = OriginPicture.Width;
                pb_Original.Height = OriginPicture.Height;
                pb_Original.Image = OriginPicture;
                //Need to solve position of picture box on the screen
                txb_sizeOfOriginal.Text = Convert.ToString(OriginPicture.Width) + "X" + Convert.ToString(OriginPicture.Height);
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            multiplyer = Convert.ToDouble(txb_multiplier.Text);

            SolutiunPicture = new Bitmap(OriginPicture.Width * Convert.ToInt32(multiplyer), OriginPicture.Width * Convert.ToInt32(multiplyer));

            for (int i = 1; i < OriginPicture.Width; i++) 
                for (int j = 1; j < OriginPicture.Height; j++)
                    for(int k = ((i - 1) * Convert.ToInt32(multiplyer) + 1);k<=i* Convert.ToInt32(multiplyer);k++)
                        for(int q = ((j - 1) * Convert.ToInt32(multiplyer) + 1); q <=j * Convert.ToInt32(multiplyer); q++)
                        {
                            SolutiunPicture.SetPixel(k, q, OriginPicture.GetPixel(i, j));
                        }
                                                                                                          
            pb_solution.Image = SolutiunPicture;
            pb_solution.Height = SolutiunPicture.Height;
            pb_solution.Width = SolutiunPicture.Width;

            txb_sizeOfSolution.Text = Convert.ToString(SolutiunPicture.Width) + "X" + Convert.ToString(SolutiunPicture.Height);

        }
    }
}

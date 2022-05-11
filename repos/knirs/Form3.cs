using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knirs
{

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void get_limit(double max, double min)
        {
            max = 0;
            min = 0;
            int i, j;
            for (i = 0; i < Getinf.x; i++)
            {
                for (j = 0; j < Getinf.y; j++)
                {
                    if (max < Getinf.T[i, j])
                    {
                        max = Getinf.T[i, j];
                    }
                    if (min > Getinf.T[i, j])
                    {
                        min = Getinf.T[i, j];
                    }
                }
            }
        }

        public double get_max()
        {
            double max = Getinf.T[0,0];
            int i, j;
            for (i = 0; i < Getinf.x; i++)
            {
                for (j = 0; j < Getinf.y; j++)
                {
                    if (max < Getinf.T[i, j])
                    {
                        max = Getinf.T[i, j];
                    }
                }
            }
            return max;
        }
        public double get_min()
        {
            double min = Getinf.T[0, 0];
            int i, j;
            for (i = 0; i < Getinf.x; i++)
            {
                for (j = 0; j < Getinf.y; j++)
                {
                    if (min > Getinf.T[i, j])
                    {
                        min = Getinf.T[i, j];
                    }
                }
            }
            return min;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double max, min;
            max = get_max();
            min = get_min();
            double r = 240 / (max - min);
            int coef = (int)(800 / Getinf.x);
            Bitmap buf = new Bitmap(Getinf.x * coef, Getinf.y * coef);
            pictureBox1.Width = Getinf.x* coef;
            pictureBox1.Height = Getinf.y* coef;
            pictureBox2.BackColor = HSVtoRGB((double)0, (double)100, (double)50);
            pictureBox3.BackColor = HSVtoRGB((double)60, (double)100, (double)50);
            pictureBox4.BackColor = HSVtoRGB((double)130, (double)100, (double)50);
            pictureBox5.BackColor = HSVtoRGB((double)240, (double)100, (double)50);
            label1.Text =  Math.Round(max).ToString()+ "°C";
            label2.Text = Math.Round(max-60 / r).ToString()+ "°C";
            label3.Text = Math.Round(max - 130 / r).ToString()+ "°C";
            label4.Text =  Math.Round(min).ToString()+ "°C";

            for (int i = 0; i < Getinf.x; i++)
            {
                for (int j = 0; j < Getinf.y; j++)
                {
                    Color c = HSVtoRGB((max-Getinf.T[i,j])*r, (double)100, (double)50);
                    for (int k = i* coef; k < i* coef + coef; k++)
                    {
                        for (int l = j* coef; l < j* coef + coef; l++)
                        {
                            buf.SetPixel(k, l, c);
                        }
                    }
                }
            }
            pictureBox1.Image = buf;
            this.Controls.Add(pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Color HSVtoRGB(double H, double S, double V)
        {

            double s = S / 100;
            double v = V / 100;
            double C = s * v;
            double X = C * (1 - Math.Abs(((H / 60.0) % 2) - 1));
            double m = v - C;
            double r, g, b;
            if (H >= 0 && H < 60)
            {
                r = C; g = X; b = 0;
            }
            else if (H >= 60 && H < 120)
            {
                r = X; g = C; b = 0;
            }
            else if (H >= 120 && H < 180)
            {
                r = 0; g = C; b = X;
            }
            else if (H >= 180 && H < 240)
            {
                r = 0; g = X; b = C;
            }
            else if (H >= 240 && H < 300)
            {
                r = X; g = 0; b = C;
            }
            else
            {
                r = C; g = 0; b = X;
            }
            int R = (int)((r + m) * 255);
            int G = (int)((g + m) * 255);
            int B = (int)((b + m) * 255);

            return Color.FromArgb(R, G, B);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




   

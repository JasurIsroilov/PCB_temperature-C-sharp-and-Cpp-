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
    public partial class MatrixForm : Form
    {
        Label[,] label = new Label[Getinf.x, Getinf.y];
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {
            for(int i= 0; i < Getinf.x; i++)
            {
                for(int j=0; j < Getinf.y; j++)
                {
                    Getinf.T[i, j] = Math.Round(Getinf.T[i, j]);
                    label[i, j] = new Label();
                    label[i, j].Text = Getinf.T[i, j].ToString();
                    label[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    label[i, j].Size = new Size(30,30);
                    label[i, j].Location = new Point(label[i, j].Location.X + (i * 30), label[i, j].Location.Y + (j * 30));
                    this.Controls.Add(label[i, j]);
                }
            }
        }
    }
}

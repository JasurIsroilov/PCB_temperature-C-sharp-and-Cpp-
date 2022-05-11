using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knirs
{
    public partial class InputForm : Form
    {

        int source_am, counter, time, x, y;
        int[] source_x1, source_x2, source_y1, source_y2;
        double[] source_pow;
        double cp, p, delta, const_time, lambda, a1, a2, alpha, C, pow, h;

        private void cp_txtb_Enter(object sender, EventArgs e)
        {
            if (cp_txtb.Text == "Введите коэффициент удельной теплоемкости")
            {
                cp_txtb.Text = "";
                cp_txtb.ForeColor = Color.Black;
            }
        }

        private void cp_txtb_Leave(object sender, EventArgs e)
        {
            if (cp_txtb.Text == "")
            {
                cp_txtb.Text = "Введите коэффициент удельной теплоемкости";
                cp_txtb.ForeColor = Color.Gray;
            }
        }

        private void p_txtb_Enter(object sender, EventArgs e)
        {
            if (p_txtb.Text == "Введите плотность материала ПП")
            {
                p_txtb.Text = "";
                p_txtb.ForeColor = Color.Black;
            }
        }

        private void p_txtb_Leave(object sender, EventArgs e)
        {
            if (p_txtb.Text == "")
            {
                p_txtb.Text = "Введите плотность материала ПП";
                p_txtb.ForeColor = Color.Gray;
            }
        }

        private void consttime_txtb_Enter(object sender, EventArgs e)
        {
            if (consttime_txtb.Text == "Введите постоянную по времени")
            {
                consttime_txtb.Text = "";
                consttime_txtb.ForeColor = Color.Black;
            }
        }

        private void consttime_txtb_Leave(object sender, EventArgs e)
        {
            if (consttime_txtb.Text == "")
            {
                consttime_txtb.Text = "Введите постоянную по времени";
                consttime_txtb.ForeColor = Color.Gray;
            }
        }

        private void width_txtb_Enter(object sender, EventArgs e)
        {
            if (width_txtb.Text == "Введите ширину ПП")
            {
                width_txtb.Text = "";
                width_txtb.ForeColor = Color.Black;
            }
        }

        private void width_txtb_Leave(object sender, EventArgs e)
        {
            if (width_txtb.Text == "")
            {
                width_txtb.Text = "Введите ширину ПП";
                width_txtb.ForeColor = Color.Gray;
            }
        }

        private void height_txtb_Enter(object sender, EventArgs e)
        {
            if (height_txtb.Text == "Введите высоту ПП")
            {
                height_txtb.Text = "";
                height_txtb.ForeColor = Color.Black;
            }
        }

        private void height_txtb_Leave(object sender, EventArgs e)
        {
            if (height_txtb.Text == "")
            {
                height_txtb.Text = "Введите высоту ПП";
                height_txtb.ForeColor = Color.Gray;
            }
        }

        private void source_am_txtb_Enter(object sender, EventArgs e)
        {
            if (source_am_txtb.Text == "Введите количество источников")
            {
                source_am_txtb.Text = "";
                source_am_txtb.ForeColor = Color.Black;
            }
        }

        private void source_am_txtb_Leave(object sender, EventArgs e)
        {
            if (source_am_txtb.Text == "")
            {
                source_am_txtb.Text = "Введите количество источников";
                source_am_txtb.ForeColor = Color.Gray;
            }
        }

        private void src_x1_txtb_Enter(object sender, EventArgs e)
        {
            if (src_x1_txtb.Text == "x1")
            {
                src_x1_txtb.Text = "";
                src_x1_txtb.ForeColor = Color.Black;
            }
        }

        private void src_x1_txtb_Leave(object sender, EventArgs e)
        {
            if (src_x1_txtb.Text == "")
            {
                src_x1_txtb.Text = "x1";
                src_x1_txtb.ForeColor = Color.Gray;
            }
        }

        private void src_x2_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void src_x2_txtb_Enter(object sender, EventArgs e)
        {
            if (src_x2_txtb.Text == "x2")
            {
                src_x2_txtb.Text = "";
                src_x2_txtb.ForeColor = Color.Black;
            }
        }

        private void src_x2_txtb_Leave(object sender, EventArgs e)
        {
            if (src_x2_txtb.Text == "")
            {
                src_x2_txtb.Text = "x2";
                src_x2_txtb.ForeColor = Color.Gray;
            }
        }

        private void src_y1_txtb_Enter(object sender, EventArgs e)
        {
            if (src_y1_txtb.Text == "y1")
            {
                src_y1_txtb.Text = "";
                src_y1_txtb.ForeColor = Color.Black;
            }
        }

        private void src_y1_txtb_Leave(object sender, EventArgs e)
        {
            if (src_y1_txtb.Text == "")
            {
                src_y1_txtb.Text = "y1";
                src_y1_txtb.ForeColor = Color.Gray;
            }
        }

        private void src_y2_txtb_Enter(object sender, EventArgs e)
        {
            if (src_y2_txtb.Text == "y2")
            {
                src_y2_txtb.Text = "";
                src_y2_txtb.ForeColor = Color.Black;
            }
        }

        private void src_y2_txtb_Leave(object sender, EventArgs e)
        {
            if (src_y2_txtb.Text == "")
            {
                src_y2_txtb.Text = "y2";
                src_y2_txtb.ForeColor = Color.Gray;
            }
        }

        private void src_pow_txtb_Enter(object sender, EventArgs e)
        {
            if (src_pow_txtb.Text == "Мощность")
            {
                src_pow_txtb.Text = "";
                src_pow_txtb.ForeColor = Color.Black;
            }
        }

        private void src_pow_txtb_Leave(object sender, EventArgs e)
        {
            if (src_pow_txtb.Text == "")
            {
                src_pow_txtb.Text = "Мощность";
                src_pow_txtb.ForeColor = Color.Gray;
            }
        }

        private void time_txtb_Enter(object sender, EventArgs e)
        {
            if (time_txtb.Text == "Время работы")
            {
                time_txtb.Text = "";
                time_txtb.ForeColor = Color.Black;
            }
        }

        private void time_txtb_Leave(object sender, EventArgs e)
        {
            if (time_txtb.Text == "")
            {
                time_txtb.Text = "Время работы";
                time_txtb.ForeColor = Color.Gray;
            }
        }

        private void h_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void h_txtb_Enter(object sender, EventArgs e)
        {
            if (h_txtb.Text == "Толщина платы")
            {
                h_txtb.Text = "";
                h_txtb.ForeColor = Color.Black;
            }
        }

        private void h_txtb_Leave(object sender, EventArgs e)
        {
            if (h_txtb.Text == "")
            {
                h_txtb.Text = "Толщина платы";
                h_txtb.ForeColor = Color.Gray;
            }
        }

        private void InputForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void alpha_txtb_Leave(object sender, EventArgs e)
        {
            if (alpha_txtb.Text == "")
            {
                alpha_txtb.Text = "Введите коэффициент теплоотдачи";
                alpha_txtb.ForeColor = Color.Gray;
            }
        }

        private void alpha_txtb_Enter(object sender, EventArgs e)
        {

            if (alpha_txtb.Text == "Введите коэффициент теплоотдачи")
            {
                alpha_txtb.Text = "";
                alpha_txtb.ForeColor = Color.Black;
            }
        }

        private void lambda_txtb_Leave(object sender, EventArgs e)
        {
            if(lambda_txtb.Text=="")
            {
                lambda_txtb.Text = "Введите коэффициент теплопроводности";
                lambda_txtb.ForeColor = Color.Gray;
            }
        }

        private void lambda_txtb_Enter(object sender, EventArgs e)
        {
            if(lambda_txtb.Text=="Введите коэффициент теплопроводности")
            {
                lambda_txtb.Text = "";
                lambda_txtb.ForeColor = Color.Black;
            }
        }

        private void delta_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void delta_txtb_Leave(object sender, EventArgs e)
        {
            if (delta_txtb.Text == "")
            {
                delta_txtb.Text = "Введите шаг дискретизации";
                delta_txtb.ForeColor = Color.Gray;
            }
        }

        private void delta_txtb_Enter(object sender, EventArgs e)
        {
            if (delta_txtb.Text == "Введите шаг дискретизации")
            {
                delta_txtb.Text = "";
                delta_txtb.ForeColor = Color.Black;
            }
        }

        private void count_source_lbl_Click(object sender, EventArgs e)
        {

        }

        double[,]  T, T1, prev_T;

        private bool compare_mat(double[,] T, double[,] T1, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (T[i,j] != T1[i,j])
                        return true;
                }
            }
            return false;
        }



        private void source_am_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void compile_btn_Click(object sender, EventArgs e)
        {
            delta = Double.Parse(delta_txtb.Text);
            lambda = Double.Parse(lambda_txtb.Text);
            alpha = Double.Parse(alpha_txtb.Text);
            cp = Double.Parse(cp_txtb.Text);
            p = Double.Parse(p_txtb.Text);
            h = Double.Parse(h_txtb.Text);
            C = cp * p;
            a1 = (C * delta * delta / lambda / const_time) / (4 + C * delta * delta / lambda / const_time);
            a2 = 1 / (4 + C * delta * delta / lambda / const_time);
            x = Int32.Parse(width_txtb.Text);
            y = Int32.Parse(height_txtb.Text);
            T = new double[x, y];
            T1 = new double[x, y];
            prev_T = new double[x, y];
            Getinf.T = new double[x, y];
            Getinf.x = x;
            Getinf.y = y;
            time = Int32.Parse(time_txtb.Text);
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    T[i,j] = 20.0;
                    T1[i,j] = 20.0;
                    prev_T[i,j] = 20.0;
                }
            for (int k = 0; k < time; k++)
            {
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        prev_T[i,j] = T[i,j];
                //Повышение температуры на источниках
                for (int a = 0; a < source_am; a++)
                {
                    for (int i = source_x1[a]; i < source_x2[a]; i++)
                    {
                        for (int j = source_y1[a]; j < source_y2[a]; j++)
                        {
                            T[i,j] = source_pow[a] / (cp * p * h * delta * delta) + prev_T[i,j];
                            prev_T[i,j] = T[i,j];
                        }
                    }
                }
                do
                {
                    for (int i = 0; i < x; i++)
                        for (int j = 0; j < y; j++)
                            T[i,j] = T1[i,j];
                    //Распространение тепла по плате
                    for (int i = 1; i < (x - 1); i++)
                        for (int j = 1; j < (y - 1); j++)
                        {
                            T1[i,j] = a1 * prev_T[i,j] + a2 * (T[i - 1,j] + T[i + 1,j] + T[i,j - 1] + T[i,j + 1]);
                        }
                    //Граничащие условия распространения тепла

                    for (int i = 0; i <= (x - 1); i++)
                    {
                        T1[i,0] = 20 * alpha * delta / (lambda + alpha * delta) + lambda / (lambda + alpha * delta) * (T[i,1]);
                        T1[i,y-1] = 20 * alpha * delta / (lambda + alpha * delta) + lambda / (lambda + alpha * delta) * (T[i,y - 2]);
                    }
                    for (int j = 0; j <= (y - 1); j++)
                    {
                        T1[0, j] = 20 * alpha * delta / (lambda + alpha * delta) + lambda / (lambda + alpha * delta) * (T[1, j]);
                        T1[x - 1, j] = 20 * alpha * delta / (lambda + alpha * delta) + lambda / (lambda + alpha * delta) * (T[x - 2, j]);
                    }
                } while (compare_mat(T, T1, x, y));
                //Процесс конвекции
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                    {
                        T[i,j] = 20 * alpha * delta * delta * const_time / (C + alpha * delta * delta * const_time) + C / (C + alpha * delta * delta * const_time) * T[i,j];
                    }
            }
            //Вывод матрицы платы
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    Getinf.T[i, j] = T[i, j];
                }
            }
            

            //MatrixForm matrixform = new MatrixForm();
           // matrixform.Show();
            Form3 TempForm = new Form3();
            TempForm.Show();
        }

        private void src_am_btn_Click(object sender, EventArgs e)
        {
            source_am = Int32.Parse(source_am_txtb.Text);
            source_x1 = new int[source_am];
            source_x2 = new int[source_am];
            source_y1 = new int[source_am];
            source_y2 = new int[source_am];
            source_pow = new double[source_am];
            const_time = Double.Parse(consttime_txtb.Text);
            src_x1_txtb.Show();
            src_x2_txtb.Show();
            src_y1_txtb.Show();
            src_y2_txtb.Show();
            src_pow_txtb.Show();
            sources_btn.Show();
            lbl_source.Show();
            count_source_lbl.Show();
            counter++;
            count_source_lbl.Text = counter.ToString();
        }

        public InputForm()
        {
            InitializeComponent();
            counter = 0;
            delta_txtb.Text = "Введите шаг дискретизации";
            delta_txtb.ForeColor = Color.Gray;
            lambda_txtb.Text = "Введите коэффициент теплопроводности";
            lambda_txtb.ForeColor = Color.Gray;
            alpha_txtb.Text = "Введите коэффициент теплоотдачи";
            alpha_txtb.ForeColor = Color.Gray;
            cp_txtb.Text = "Введите коэффициент удельной теплоемкости";
            cp_txtb.ForeColor = Color.Gray;
            p_txtb.Text = "Введите плотность материала ПП";
            p_txtb.ForeColor = Color.Gray;
            consttime_txtb.Text = "Введите постоянную по времени";
            consttime_txtb.ForeColor = Color.Gray;
            width_txtb.Text = "Введите ширину ПП";
            width_txtb.ForeColor = Color.Gray;
            height_txtb.Text = "Введите высоту ПП";
            height_txtb.ForeColor = Color.Gray;
            source_am_txtb.Text = "Введите количество источников";
            source_am_txtb.ForeColor = Color.Gray;
            src_x1_txtb.Text = "x1";
            src_x1_txtb.ForeColor = Color.Gray;
            src_x2_txtb.Text = "x2";
            src_x2_txtb.ForeColor = Color.Gray;
            src_y1_txtb.Text = "y1";
            src_y1_txtb.ForeColor = Color.Gray;
            src_y2_txtb.Text = "y2";
            src_y2_txtb.ForeColor = Color.Gray;
            src_pow_txtb.Text = "Мощность";
            src_pow_txtb.ForeColor = Color.Gray;
            time_txtb.Text = "Время работы";
            time_txtb.ForeColor = Color.Gray;
            h_txtb.Text = "Толщина платы";
            h_txtb.ForeColor = Color.Gray;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            src_x1_txtb.Hide();
            src_x2_txtb.Hide();
            src_y1_txtb.Hide();
            src_y2_txtb.Hide();
            src_pow_txtb.Hide();
            sources_btn.Hide();
            time_txtb.Hide();
            lbl_source.Hide();
            count_source_lbl.Hide();
            time_lbl.Hide();
            compile_btn.Hide();
        }

        private void sources_btn_Click(object sender, EventArgs e)
        {
            count_source_lbl.Text = (counter+1).ToString();
            source_x1[counter - 1] = Int32.Parse(src_x1_txtb.Text);
            source_x2[counter - 1] = Int32.Parse(src_x2_txtb.Text);
            source_y1[counter - 1] = Int32.Parse(src_y1_txtb.Text);
            source_y2[counter - 1] = Int32.Parse(src_y2_txtb.Text);
            pow = Double.Parse(src_pow_txtb.Text);
            source_pow[counter - 1] = pow * const_time / (Convert.ToDouble(source_x2[counter - 1]) - Convert.ToDouble(source_x1[counter - 1])) / (Convert.ToDouble(source_y2[counter - 1]) - Convert.ToDouble(source_y1[counter - 1]));
            if (counter==source_am)
            {
                src_x1_txtb.Hide();
                src_x2_txtb.Hide();
                src_y1_txtb.Hide();
                src_y2_txtb.Hide();
                src_pow_txtb.Hide();
                sources_btn.Hide();
                count_source_lbl.Hide();
                lbl_source.Text = "Все источники были рассмотрены!";
                time_txtb.Show();
                //time_lbl.Show();
                compile_btn.Show();
                return;
            }
            counter++;
            src_x1_txtb.Text = "x1";
            src_x2_txtb.Text = "x2";
            src_y1_txtb.Text = "y1";
            src_y2_txtb.Text = "y2";
            src_pow_txtb.Text = "Мощность";
            src_pow_txtb.ForeColor = Color.Gray;
            src_x1_txtb.ForeColor = Color.Gray;
            src_x2_txtb.ForeColor = Color.Gray;
            src_y1_txtb.ForeColor = Color.Gray;
            src_y2_txtb.ForeColor = Color.Gray;
        }
    }
}

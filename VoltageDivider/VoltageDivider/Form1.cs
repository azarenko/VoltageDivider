using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VoltageDivider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nominal_number.SelectedIndex = 2;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double power = double.Parse(power_value.Text);
                double divider = double.Parse(divider_value.Text);
                double ground = double.Parse(ground_value.Text);
                double current = double.Parse(current_value.Text);

                int nominalnumber = 3;

                for (int i = 0; i < nominal_number.SelectedIndex; i++)
                {
                    nominalnumber *= 2;
                }

                double r1Optimal = ((power - divider) / current) * Math.Pow(10, 6);
                double r2Optimal = ((divider - ground) / current) * Math.Pow(10, 6);

                double[] nominals = new double[nominalnumber+1];
                int roundNum = (nominalnumber < 48 ? 1 : 2);
                for (int i = 0; i < nominalnumber+1; i++)
                {
                    nominals[i] = Math.Round(Math.Pow(10, i / (double)nominalnumber), roundNum, MidpointRounding.AwayFromZero);
                }

                int r1degree = 0;
                do
                {
                    if (r1Optimal > 0 && r1Optimal <= 10)
                    {
                        break;
                    }

                    r1degree++;
                    r1Optimal /= 10;
                }
                while (true);

                int r2degree = 0;
                do
                {
                    if (r2Optimal > 0 && r2Optimal <= 10)
                    {
                        break;
                    }

                    r2degree++;
                    r2Optimal /= 10;
                }
                while (true);

                int bestNominalIndex1 = 0;
                double min_error1 = double.MaxValue;
                for(int i = 0; i < nominals.Length; i++)
                {
                    double error = Math.Abs(r1Optimal - nominals[i]);
                    if(error < min_error1)
                    {
                        min_error1 = error;
                        bestNominalIndex1 = i;
                    }
                }
                
                R1_Value.Text = GenerateText(nominals[bestNominalIndex1], r1degree);

                int bestNominalIndex2 = 0;
                double min_error2 = double.MaxValue;
                for (int i = 0; i < nominals.Length; i++)
                {
                    double error = Math.Abs(r2Optimal - nominals[i]);
                    if (error < min_error2)
                    {
                        min_error2 = error;
                        bestNominalIndex2 = i;
                    }
                }

                R2_Value.Text = GenerateText(nominals[bestNominalIndex2], r2degree);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public string GenerateText(double nominal, int degree)
        {
            int factor = degree % 3;
            string degreeName = string.Empty;
            switch((int)Math.Floor(degree / 3.0))
            {                
                case 1:
                    {
                        degreeName = "k";
                    }; break;
                case 2:
                    {
                        degreeName = "M";
                    }; break;
                case 0:
                default:
                    {

                    }; break;
            }

            return string.Format("{0} {1}Ohm", nominal * Math.Pow(10, factor), degreeName);
        }
    }
}

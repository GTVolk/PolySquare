using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolySquare
{
    public partial class ColorForm : Form
    {
        CalculateForm CalculateForm;

        public ColorForm(CalculateForm form)
        {
            InitializeComponent();

            CalculateForm = form;
        }

        private void ColorBut1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPanel.BackColor = colorDialog1.Color;
                switch (ColorBox.SelectedIndex)
                {
                    case 0:
                        {
                            CalculateForm.ColorOx = colorDialog1.Color;
                            break;
                        }
                    case 1:
                        {
                            CalculateForm.ColorOy = colorDialog1.Color;
                            break;
                        }
                    case 2:
                        {
                            CalculateForm.ColorPoint = colorDialog1.Color;
                            break;
                        }
                    case 3:
                        {
                            CalculateForm.ColorEdge = colorDialog1.Color;
                            break;
                        }
                    case 4:
                        {
                            CalculateForm.ColorText = colorDialog1.Color;
                            break;
                        }
                    default:
                    {
                        break;
                    }
                }
                CalculateForm.GetDrawPanel().Refresh();
            }
        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorBox.SelectedIndex)
            {
                case 0:
                    {
                        ColorPanel.BackColor = CalculateForm.ColorOx;
                        break;
                    }
                case 1:
                    {
                        ColorPanel.BackColor = CalculateForm.ColorOy;
                        break;
                    }
                case 2:
                    {
                        ColorPanel.BackColor = CalculateForm.ColorPoint;
                        break;
                    }
                case 3:
                    {
                        ColorPanel.BackColor = CalculateForm.ColorEdge;
                        break;
                    }
                case 4:
                    {
                        ColorPanel.BackColor = CalculateForm.ColorText;
                        break;
                    }
                default:
                    {
                        ColorPanel.BackColor = Color.White;
                        break;
                    }
            }
        }
    }
}

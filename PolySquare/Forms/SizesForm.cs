using System;
using System.Windows.Forms;

namespace PolySquare
{
    public partial class SizesForm : Form
    {
        CalculateForm CalculateForm;

        public SizesForm(CalculateForm form)
        {
            InitializeComponent();

            this.CalculateForm = form;
        }
        private void SizesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SizesBox.SelectedIndex)
            {
                case 0:
                    {
                        NumericSize.Value = CalculateForm.SizeOxOy;
                        break;
                    }
                case 1:
                    {
                        NumericSize.Value = CalculateForm.SizePoint;
                        break;
                    }
                case 2:
                    {
                        NumericSize.Value = CalculateForm.SizeEdge;
                        break;
                    }
                case 3:
                    {
                        NumericSize.Value = CalculateForm.SizeText;
                        break;
                    }
                default:
                    {
                        NumericSize.Value = 1;
                        break;
                    }
            }
        }

        private void ChangeSizeButton_Click(object sender, EventArgs e)
        {
            switch (SizesBox.SelectedIndex)
            {
                case 0:
                    {
                        CalculateForm.SizeOxOy = Convert.ToByte(NumericSize.Value);
                        break;
                    }
                case 1:
                    {
                        CalculateForm.SizePoint = Convert.ToByte(NumericSize.Value);
                        break;
                    }
                case 2:
                    {
                        CalculateForm.SizeEdge = Convert.ToByte(NumericSize.Value);
                        break;
                    }
                case 3:
                    {
                        CalculateForm.SizeText = Convert.ToByte(NumericSize.Value);
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
}

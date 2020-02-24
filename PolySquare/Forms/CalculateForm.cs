using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Find3DPointsSetPolygonArea;
using DataTypes;

namespace PolySquare
{
    public partial class CalculateForm : Form
    {
        public static byte PointsN { get; set; }
        public static Color ColorOx { get; set; }
        public static Color ColorOy { get; set; }
        public static Color ColorPoint { get; set; }
        public static Color ColorEdge { get; set; }
        public static Color ColorText { get; set; }
        public static bool PolyCreated { get; set; }
        public static byte SizeOxOy { get; set; }
        public static byte SizePoint { get; set; }
        public static byte SizeEdge { get; set; }
        public static byte SizeText { get; set; }
        public static List<MyPoint> LastPolyPts { get; set; }
        public CalculateForm()
        {
            InitializeComponent();

            PointsN = 0;
            ColorOx = Color.Blue;
            ColorOy = Color.Red;
            ColorPoint = Color.Black;
            ColorEdge = Color.Yellow;
            ColorText = Color.Green;
            SizeOxOy = 2;
            SizePoint = 2;
            SizeEdge = 2;
            SizeText = 8;
            PolyCreated = false;
            LastPolyPts = new List<MyPoint>();
            DrawPanel.Location = new Point(300, 60);
            DrawPanel.Height = 410;
            DrawPanel.Width = 410;

            ReadConfig();
        }
        private void ReadConfig()
        {
            try
            {
                using (FileStream fs = new FileStream("Config.cfg", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader fin = new StreamReader(fs))
                    {
                        double[] a = new double[3];
                        byte PN = 0;
                        String str;

                        while ((str = fin.ReadLine()) != null)
                        {
                            SelectConfigStr(str);
                            if (str.Contains("[LAST POINTS]"))
                                while ((str = fin.ReadLine()) != "[END LAST POINTS]" && str != null)
                                {
                                    a = PointFromStrToArr(str);
                                    PN = PointsN;
                                    AddPointListBox(ref PN, a[0].ToString(), a[1].ToString(), a[2].ToString());
                                    PointsN = PN;
                                }
                        }
                        fin.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SelectConfigStr(String str)
        {
            if (str.Contains("Color"))
            {
                if (str.Contains("AxisOx")) GetColor("AxisOx", str);
                if (str.Contains("AxisOy")) GetColor("AxisOy", str);
                if (str.Contains("Points")) GetColor("Point", str);
                if (str.Contains("Edges")) GetColor("Edge", str);
                if (str.Contains("Text")) GetColor("Text", str);
            }
            if (str.Contains("Size"))
            {
                if (str.Contains("Axis")) GetSize("Axis", str);
                if (str.Contains("Points")) GetSize("Point", str);
                if (str.Contains("Edges")) GetSize("Edge", str);
                if (str.Contains("Text")) GetSize("Text", str);
            }

        }
        private void GetColor(string parametr, string value)
        {
            switch (parametr)
            {
                case "AxisOx":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        ColorOx = Color.FromName(t);
                        break;
                    }
                case "AxisOy":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        ColorOy = Color.FromName(t);
                        break;
                    }
                case "Point":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        ColorPoint = Color.FromName(t);
                        break;
                    }
                case "Edge":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        ColorEdge = Color.FromName(t);
                        break;
                    }
                case "Text":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        ColorText = Color.FromName(t);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void GetSize(string parametr, string value)
        {
            switch (parametr)
            {
                case "Axis":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        SizeOxOy = byte.Parse(t);
                        break;
                    }
                case "Point":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        SizePoint = byte.Parse(t);
                        break;
                    }
                case "Edge":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        SizeEdge = byte.Parse(t);
                        break;
                    }
                case "Text":
                    {
                        string t = "";
                        for (int i = value.IndexOf("[") + 1; i < value.IndexOf("]"); i++)
                            t += value[i];
                        SizeText = byte.Parse(t);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void WriteConfig()
        {
            try
            {
                using (FileStream fs = new FileStream("Config.cfg", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter fout = new StreamWriter(fs))
                    {
                        fout.WriteLine("//Config file. DO NOT EDIT MANUALLY!");
                        fout.WriteLine("[CONFIG]");
                        fout.WriteLine("[COLORS]");
                        fout.WriteLine("ColorAxisOx=" + ColorOx);
                        fout.WriteLine("ColorAxisOy=" + ColorOy);
                        fout.WriteLine("ColorPoints=" + ColorPoint);
                        fout.WriteLine("ColorEdges=" + ColorEdge);
                        fout.WriteLine("ColorText=" + ColorText);
                        fout.WriteLine("[END COLORS]");
                        fout.WriteLine("[SIZES]");
                        fout.WriteLine("SizeAxis=" + "[" + SizeOxOy + "]");
                        fout.WriteLine("SizePoints=" + "[" + SizePoint + "]");
                        fout.WriteLine("SizeEdges=" + "[" + SizeEdge + "]");
                        fout.WriteLine("SizeText=" + "[" + SizeText + "]");
                        fout.WriteLine("[END SIZES]");
                        fout.WriteLine("[LAST POINTS]");
                        for (int i = 0; i < PointsN; i++)
                            fout.WriteLine(VertexesBox.Items[i]);
                        fout.WriteLine("[END LAST POINTS]");
                        fout.WriteLine("[END CONFIG]");
                        fout.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double[] PointFromStrToArr(string s)
        {
            double[] a = new double[3];
            int IndS = 0, IndE = 0, i = 0;
            String t = "";
            IndS = s.IndexOf(" X = ") + 5;
            IndE = s.IndexOf(" Y = ") - 1;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[0] = double.Parse(t);
            t = "";
            IndS = s.IndexOf(" Y = ") + 5;
            IndE = s.IndexOf(" Z = ") - 1;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[1] = double.Parse(t);
            t = "";
            IndS = s.IndexOf(" Z = ") + 5;
            IndE = s.Length;
            for (i = IndS; i < IndE; i++)
                t = t + s[i];
            a[2] = double.Parse(t);
            return a;
        }
        private void AboutInfoMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        private void LoadVertexesFileMenuItem_Click(object sender, EventArgs args)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)) {
                        if (fs != null)
                        {
                            BinaryReader fin = new BinaryReader(fs);
                            using (fin)
                            {
                                double[] a = new double[3];
                                int pos = 0;
                                int length = (int)fin.BaseStream.Length;
                                while (pos < length)
                                {
                                    a[0] = fin.ReadDouble();
                                    pos += sizeof(double);
                                    a[1] = fin.ReadDouble();
                                    pos += sizeof(double);
                                    a[2] = fin.ReadDouble();
                                    pos += sizeof(double);
                                    byte PN = PointsN;
                                    AddPointListBox(ref PN, Convert.ToString(a[0]), Convert.ToString(a[1]), Convert.ToString(a[2]));
                                    PointsN = PN;
                                }
                            }
                            fin.Close();
                        }
                        fs.Close();
                    }
                
            }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveVertexesFileMenuItem_Click(object sender, EventArgs args)
        {
            try
            {
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (BinaryWriter fout = new BinaryWriter(fs))
                        {

                            double[] a = new double[3];
                            for (int i = 0; i < PointsN; i++)
                            {
                                a = PointFromStrToArr((String)VertexesBox.Items[i]);
                                fout.Write(a[0]);
                                fout.Write(a[1]);
                                fout.Write(a[2]);
                            }

                            fout.Close();
                        }
                        fs.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitFileMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectColorsViewMenuItem_Click(object sender, EventArgs e)
        {
            (new ColorForm(this)).Show();
        }
        private void SelectSizesViewMenuItem_Click(object sender, EventArgs e)
        {
            (new SizesForm(this)).Show();
        }
        private void FindEdgePoints(List<MyPoint> pts,ref int x1, ref int x2, ref int y1, ref int y2)
        {
            x1 = 0; x2 = 0; y1 = 0; y2 = 0;
            for (int i = 0; i < pts.Count; i++)
            {
                int ptx = Convert.ToInt32(pts[i].x);
                if (ptx < x1) x1 = ptx;
                if (ptx > x2) x2 = ptx;
                int pty = Convert.ToInt32(pts[i].y);
                if (pty < y1) y1 = pty;
                if (pty > y2) y2 = pty;
            }
        }
        private void SysCoord(int xmax, int xmin, int ymax, int ymin, ref int h)
        {
            using (Graphics g = DrawPanel.CreateGraphics())
            {

                int r = DrawPanel.Height / 2;
                int tmaxx, tmaxy, tmax;
                if (Math.Abs(xmax) > Math.Abs(xmin)) tmaxx = xmax;
                else tmaxx = xmin;
                if (Math.Abs(ymax) > Math.Abs(ymin)) tmaxy = ymax;
                else tmaxy = ymin;
                if (Math.Abs(tmaxx) > Math.Abs(tmaxy)) tmax = Math.Abs(tmaxx);
                else tmax = Math.Abs(tmaxy);
                h = (r / (tmax + 1));

                using (Pen p = new Pen(Color.White, SizeOxOy + 3))
                {
                    for (int i = 1; i < h; i++)
                    {
                        int ah1 = r + i * h;
                        int ah2 = r - i * h;
                        p.Color = ColorOx;
                        g.DrawLine(p, ah1, r + 5, ah1, r - 5);
                        g.DrawLine(p, ah2, r + 5, ah2, r - 5);
                        p.Color = ColorOy;
                        g.DrawLine(p, r + 5, ah1, r - 5, ah1);
                        g.DrawLine(p, r + 5, ah2, r - 5, ah2);
                    }
                }

                Point Start = new Point(r, r);
                Point LabelOx = new Point(r * 2 - 25, r + 15);
                Point LabelOy = new Point(r + 15, 13);

                using (Brush Text = new SolidBrush(ColorText))
                {
                    using (Font Arial = new Font("Arial", SizeText + 2))
                    {
                        g.DrawString("0", Arial, Text, Start);
                        g.DrawString("Ox", Arial, Text, LabelOx);
                        g.DrawString("Oy", Arial, Text, LabelOy);
                    }
                }
            }
        }
        private float Center(double pt, int h)
        {
            return (Convert.ToSingle(((DrawPanel.Height / 2) + pt * h)));
        }
        private void DrawVertexes(Graphics g, Pen p, int h, List<MyPoint> pts)
        {
            using (Brush Text = new SolidBrush(ColorText))
            {
                using (Font Arial = new Font("Arial", SizeText))
                {

                    for (int i = 0; i < pts.Count; i++)
                    {
                        float pstx = Center(pts[i].x, h) - SizePoint;
                        float psty = Center(-pts[i].y, h) - SizePoint;
                        g.DrawEllipse(p, pstx, psty, SizePoint, SizePoint);
                        g.DrawString("(" + Convert.ToSingle(pts[i].x) + ";" + Convert.ToSingle(pts[i].y) + ")", Arial, Text, new PointF(pstx + 3, psty - 3));
                    }
                }
            }
        }

        public void DrawPolyPoints(List<MyPoint> pts)
        {
            try
            {
                int h = 0;
                int xmax = 0, xmin = 0, ymax = 0, ymin = 0;
                FindEdgePoints(pts, ref xmax, ref xmin, ref ymax, ref ymin);
                SysCoord(xmax, xmin, ymax, ymin, ref h);
                PointF[] PolyPts = new PointF[pts.Count];
                for (int i = 0; i < pts.Count; i++)
                    PolyPts[i] = new PointF(Center(pts[i].x, h), Center(-pts[i].y, h));
                using (Graphics g = DrawPanel.CreateGraphics())
                {
                    using (Pen p = new Pen(ColorPoint, SizePoint))
                    {
                        DrawVertexes(g, p, h, pts);
                        p.Color = ColorEdge;
                        p.Brush = new SolidBrush(ColorEdge);
                        p.Width = SizeEdge;

                        g.DrawPolygon(p, PolyPts);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HelpInfoMenuItem_Click(object sender, EventArgs args)
        {
            try
            {
                System.Diagnostics.Process.Start("HELP.txt");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + '\r' + e.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void XInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !(sender as TextBox).Text.Contains(","))
                e.KeyChar = ',';
            else if ((e.KeyChar == '-') && !(sender as TextBox).Text.Contains("-") && ((sender as TextBox).Text == ""))
                    e.KeyChar = '-';
                 else if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                    e.Handled = true;
       }
        private void YInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !(sender as TextBox).Text.Contains(","))
                e.KeyChar = ',';
            else if ((e.KeyChar == '-') && !(sender as TextBox).Text.Contains("-") && ((sender as TextBox).Text == ""))
                e.KeyChar = '-';
            else if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        private void ZInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !(sender as TextBox).Text.Contains(","))
                e.KeyChar = ',';
            else if ((e.KeyChar == '-') && !(sender as TextBox).Text.Contains("-") && ((sender as TextBox).Text == ""))
                e.KeyChar = '-';
            else if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private String TextBoxToStr(int N,String s1, String s2, String s3)
        {
            return "" + N + ". X = " + s1 + "  Y = " + s2 + "  Z = " + s3;
        }

        private bool ListBoxContainsPoint(byte PN, String dx, String dy, String dz)
        {
            for (int i = 0; i < PN; i++)
            {
                Object ts1 = TextBoxToStr((i + 1), dx, dy, dz);
                if (VertexesBox.Items.Contains(ts1)) return true;
            }
            return false;
        }

        private bool AddPointListBox(ref byte PN, string dx, string dy, string dz)
        {
            Object ts2 = TextBoxToStr((PN + 1), dx, dy, dz);
            if (!ListBoxContainsPoint(PN, dx, dy, dz))
            {
                ++PN;
                VertexesBox.Items.Add(ts2);
                return true;
            }
            else
                return false;
        }
        private void AddPoint_Click(object sender, EventArgs e)
        {
            if((XInputBox.Text != "") && (YInputBox.Text != "") && (ZInputBox.Text != ""))
            {
               byte PN = PointsN;
               bool er = AddPointListBox(ref PN, XInputBox.Text, YInputBox.Text, ZInputBox.Text);
               PointsN = PN;
               if (!er) MessageBox.Show("Такая точка уже есть!");
            }
            else MessageBox.Show("Сначала введите координаты точки!");
            XInputBox.Text = "";
            YInputBox.Text = "";
            ZInputBox.Text = "";
        }

        private void DeletePoint_Click(object sender, EventArgs e)
        {
            if (VertexesBox.SelectedIndex != -1)
            {
                VertexesBox.Items.RemoveAt(VertexesBox.SelectedIndex);
                --PointsN;
                for (int i = 0; i < PointsN; i++)
                {
                    double [] ar = new double[2];
                    ar = PointFromStrToArr((String)VertexesBox.Items[i]);
                    String t = TextBoxToStr((i+1),Convert.ToString(ar[0]),Convert.ToString(ar[1]),Convert.ToString(ar[2]));
                    VertexesBox.Items.RemoveAt(i);
                    VertexesBox.Items.Insert(i, t);
                 }
            }
            else MessageBox.Show("Сначала выберете точку из списка!");
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (PointsN < 3)
            {
                MessageBox.Show("Введено слишком мало точек! Минимум 3 точки.");
                return;
            }
            string[] a = new String[PointsN];
            int i = 0;
            foreach (object x in VertexesBox.Items)
                a[i++] = (String)x;
            double Square = 0;
            List<MyPoint> pts = new List<MyPoint>();
            if (Find3DPolygon.CalculatePolySq(a, ref Square,ref pts))
            {
                OutputBox.Text = "Итак, программа получила, что:\nПлощадь = " + Square + "\nМногоугольник сосотоит из " + pts.Count + " точек.";
                LastPolyPts = pts;
                PolyCreated = true;
                DrawPanel.Refresh();
                DrawPolyPoints(LastPolyPts);
            }
            else MessageBox.Show("Ошибка: не удалось вычислить площадь при заданных вершинах!");
        }

        private void AddPointOperationsMenuItem_Click(object sender, EventArgs e)
        {
            AddPoint_Click(sender, e);
        }

        private void DeletePointOperationsMenuItem_Click(object sender, EventArgs e)
        {
            DeletePoint_Click(sender, e);
        }

        private void CalculateOperationsMenuItem_Click(object sender, EventArgs e)
        {
            Calculate_Click(sender, e);
        }

        public void DrawPanel_Redraw()
        {
            using (Graphics g = DrawPanel.CreateGraphics())
            {
                using (Pen px = new Pen(ColorOx, SizeOxOy))
                {
                    px.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    g.DrawLine(px, new Point(0, DrawPanel.Height / 2), new Point(DrawPanel.Width, DrawPanel.Height / 2));

                    using (Pen py = new Pen(ColorOy, SizeOxOy))
                    {
                        py.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                        g.DrawLine(py, new Point(DrawPanel.Width / 2, DrawPanel.Height), new Point(DrawPanel.Width / 2, 0));
                        if (PolyCreated) this.DrawPolyPoints(LastPolyPts);
                    }
                }
            }
        }
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
             DrawPanel_Redraw();
        }

        private void CalculateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (XInputBox.Focused || YInputBox.Focused || ZInputBox.Focused))
            {
                AddPoint_Click(sender, e);
                XInputBox.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Delete && VertexesBox.Focused)
            {
                DeletePoint_Click(sender, e);
            }
        }

        public Panel GetDrawPanel()
        {
            return DrawPanel;
        }
    }
}

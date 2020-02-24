namespace PolySquare
{
    partial class ColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorBut1 = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ColorBut1
            // 
            this.ColorBut1.Location = new System.Drawing.Point(12, 39);
            this.ColorBut1.Name = "ColorBut1";
            this.ColorBut1.Size = new System.Drawing.Size(168, 24);
            this.ColorBut1.TabIndex = 6;
            this.ColorBut1.Text = "Выбрать цвет";
            this.ColorBut1.UseVisualStyleBackColor = true;
            this.ColorBut1.Click += new System.EventHandler(this.ColorBut1_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColorBox.Items.AddRange(new object[] {
            "Цвет оси Ox",
            "Цвет оси Oy",
            "Цвет вершин",
            "Цвет ребер",
            "Цвет надписей"});
            this.ColorBox.Location = new System.Drawing.Point(12, 12);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(170, 21);
            this.ColorBox.TabIndex = 12;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPanel.Location = new System.Drawing.Point(186, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(55, 22);
            this.ColorPanel.TabIndex = 13;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 78);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorBut1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Цвет элементов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorBut1;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.Panel ColorPanel;
    }
}
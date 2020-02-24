namespace PolySquare
{
    partial class SizesForm
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
            this.SizesBox = new System.Windows.Forms.ComboBox();
            this.ChangeSizeButton = new System.Windows.Forms.Button();
            this.PanelSizes = new System.Windows.Forms.Panel();
            this.LabelSize = new System.Windows.Forms.Label();
            this.NumericSize = new System.Windows.Forms.NumericUpDown();
            this.PanelSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSize)).BeginInit();
            this.SuspendLayout();
            // 
            // SizesBox
            // 
            this.SizesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizesBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SizesBox.Items.AddRange(new object[] {
            "Размеры осей координат",
            "Размер вершин",
            "Рзамер ребер",
            "Размер текста"});
            this.SizesBox.Location = new System.Drawing.Point(12, 12);
            this.SizesBox.Name = "SizesBox";
            this.SizesBox.Size = new System.Drawing.Size(182, 21);
            this.SizesBox.TabIndex = 0;
            this.SizesBox.SelectedIndexChanged += new System.EventHandler(this.SizesBox_SelectedIndexChanged);
            // 
            // ChangeSizeButton
            // 
            this.ChangeSizeButton.Location = new System.Drawing.Point(12, 39);
            this.ChangeSizeButton.Name = "ChangeSizeButton";
            this.ChangeSizeButton.Size = new System.Drawing.Size(182, 25);
            this.ChangeSizeButton.TabIndex = 1;
            this.ChangeSizeButton.Text = "Подтвердить";
            this.ChangeSizeButton.UseVisualStyleBackColor = true;
            this.ChangeSizeButton.Click += new System.EventHandler(this.ChangeSizeButton_Click);
            // 
            // PanelSizes
            // 
            this.PanelSizes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelSizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSizes.Controls.Add(this.LabelSize);
            this.PanelSizes.Controls.Add(this.NumericSize);
            this.PanelSizes.Location = new System.Drawing.Point(211, 12);
            this.PanelSizes.Name = "PanelSizes";
            this.PanelSizes.Size = new System.Drawing.Size(161, 52);
            this.PanelSizes.TabIndex = 2;
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(6, 17);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(91, 13);
            this.LabelSize.TabIndex = 1;
            this.LabelSize.Text = "Размер объекта";
            // 
            // NumericSize
            // 
            this.NumericSize.Location = new System.Drawing.Point(103, 15);
            this.NumericSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumericSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericSize.Name = "NumericSize";
            this.NumericSize.Size = new System.Drawing.Size(46, 20);
            this.NumericSize.TabIndex = 0;
            this.NumericSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 87);
            this.Controls.Add(this.PanelSizes);
            this.Controls.Add(this.ChangeSizeButton);
            this.Controls.Add(this.SizesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SizesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Размеры";
            this.PanelSizes.ResumeLayout(false);
            this.PanelSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SizesBox;
        private System.Windows.Forms.Button ChangeSizeButton;
        private System.Windows.Forms.Panel PanelSizes;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.NumericUpDown NumericSize;
    }
}
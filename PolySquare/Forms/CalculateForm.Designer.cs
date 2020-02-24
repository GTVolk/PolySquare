namespace PolySquare
{
    partial class CalculateForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            WriteConfig();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            this.XInputBox = new System.Windows.Forms.TextBox();
            this.ZInputBox = new System.Windows.Forms.TextBox();
            this.YInputBox = new System.Windows.Forms.TextBox();
            this.DeletePoint = new System.Windows.Forms.Button();
            this.AddPoint = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.VertexesBox = new System.Windows.Forms.ListBox();
            this.ProgramName = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadVertexesFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveVertexesFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectColorsViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectSizesViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPointOperationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePointOperationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateOperationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XInputBox
            // 
            resources.ApplyResources(this.XInputBox, "XInputBox");
            this.XInputBox.Name = "XInputBox";
            this.XInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XInputBox_KeyPress);
            // 
            // ZInputBox
            // 
            resources.ApplyResources(this.ZInputBox, "ZInputBox");
            this.ZInputBox.Name = "ZInputBox";
            this.ZInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZInputBox_KeyPress);
            // 
            // YInputBox
            // 
            resources.ApplyResources(this.YInputBox, "YInputBox");
            this.YInputBox.Name = "YInputBox";
            this.YInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YInputBox_KeyPress);
            // 
            // DeletePoint
            // 
            resources.ApplyResources(this.DeletePoint, "DeletePoint");
            this.DeletePoint.Name = "DeletePoint";
            this.DeletePoint.UseVisualStyleBackColor = true;
            this.DeletePoint.Click += new System.EventHandler(this.DeletePoint_Click);
            // 
            // AddPoint
            // 
            resources.ApplyResources(this.AddPoint, "AddPoint");
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DrawPanel, "DrawPanel");
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Calculate
            // 
            resources.ApplyResources(this.Calculate, "Calculate");
            this.Calculate.Name = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // VertexesBox
            // 
            this.VertexesBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VertexesBox.FormattingEnabled = true;
            resources.ApplyResources(this.VertexesBox, "VertexesBox");
            this.VertexesBox.Name = "VertexesBox";
            // 
            // ProgramName
            // 
            this.ProgramName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.ProgramName, "ProgramName");
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenu,
            this.ViewToolStripMenu,
            this.OperationsToolStripMenu,
            this.InfoToolStripMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadVertexesFileMenuItem,
            this.SaveVertexesFileMenuItem,
            this.ExitFileMenuItem});
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            resources.ApplyResources(this.FileToolStripMenu, "FileToolStripMenu");
            // 
            // LoadVertexesFileMenuItem
            // 
            this.LoadVertexesFileMenuItem.Name = "LoadVertexesFileMenuItem";
            resources.ApplyResources(this.LoadVertexesFileMenuItem, "LoadVertexesFileMenuItem");
            this.LoadVertexesFileMenuItem.Click += new System.EventHandler(this.LoadVertexesFileMenuItem_Click);
            // 
            // SaveVertexesFileMenuItem
            // 
            this.SaveVertexesFileMenuItem.Name = "SaveVertexesFileMenuItem";
            resources.ApplyResources(this.SaveVertexesFileMenuItem, "SaveVertexesFileMenuItem");
            this.SaveVertexesFileMenuItem.Click += new System.EventHandler(this.SaveVertexesFileMenuItem_Click);
            // 
            // ExitFileMenuItem
            // 
            this.ExitFileMenuItem.Name = "ExitFileMenuItem";
            resources.ApplyResources(this.ExitFileMenuItem, "ExitFileMenuItem");
            this.ExitFileMenuItem.Click += new System.EventHandler(this.ExitFileMenuItem_Click);
            // 
            // ViewToolStripMenu
            // 
            this.ViewToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectColorsViewMenuItem,
            this.SelectSizesViewMenuItem});
            this.ViewToolStripMenu.Name = "ViewToolStripMenu";
            resources.ApplyResources(this.ViewToolStripMenu, "ViewToolStripMenu");
            // 
            // SelectColorsViewMenuItem
            // 
            this.SelectColorsViewMenuItem.Name = "SelectColorsViewMenuItem";
            resources.ApplyResources(this.SelectColorsViewMenuItem, "SelectColorsViewMenuItem");
            this.SelectColorsViewMenuItem.Click += new System.EventHandler(this.SelectColorsViewMenuItem_Click);
            // 
            // 
            // SelectSizesViewMenuItem
            // 
            this.SelectSizesViewMenuItem.Name = "SelectSizesViewMenuItem";
            resources.ApplyResources(this.SelectSizesViewMenuItem, "SelectSizesViewMenuItem");
            this.SelectSizesViewMenuItem.Click += new System.EventHandler(this.SelectSizesViewMenuItem_Click);
            // 
            // OperationsToolStripMenu
            // 
            this.OperationsToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPointOperationsMenuItem,
            this.DeletePointOperationsMenuItem,
            this.CalculateOperationsMenuItem});
            this.OperationsToolStripMenu.Name = "OperationsToolStripMenu";
            resources.ApplyResources(this.OperationsToolStripMenu, "OperationsToolStripMenu");
            // 
            // AddPointOperationsMenuItem
            // 
            this.AddPointOperationsMenuItem.Name = "AddPointOperationsMenuItem";
            resources.ApplyResources(this.AddPointOperationsMenuItem, "AddPointOperationsMenuItem");
            this.AddPointOperationsMenuItem.Click += new System.EventHandler(this.AddPointOperationsMenuItem_Click);
            // 
            // DeletePointOperationsMenuItem
            // 
            this.DeletePointOperationsMenuItem.Name = "DeletePointOperationsMenuItem";
            resources.ApplyResources(this.DeletePointOperationsMenuItem, "DeletePointOperationsMenuItem");
            this.DeletePointOperationsMenuItem.Click += new System.EventHandler(this.DeletePointOperationsMenuItem_Click);
            // 
            // CalculateOperationsMenuItem
            // 
            this.CalculateOperationsMenuItem.Name = "CalculateOperationsMenuItem";
            resources.ApplyResources(this.CalculateOperationsMenuItem, "CalculateOperationsMenuItem");
            this.CalculateOperationsMenuItem.Click += new System.EventHandler(this.CalculateOperationsMenuItem_Click);
            // 
            // InfoToolStripMenu
            // 
            this.InfoToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpInfoMenuItem,
            this.AboutInfoMenuItem});
            this.InfoToolStripMenu.Name = "InfoToolStripMenu";
            resources.ApplyResources(this.InfoToolStripMenu, "InfoToolStripMenu");
            // 
            // HelpInfoMenuItem
            // 
            this.HelpInfoMenuItem.Name = "HelpInfoMenuItem";
            resources.ApplyResources(this.HelpInfoMenuItem, "HelpInfoMenuItem");
            this.HelpInfoMenuItem.Click += new System.EventHandler(this.HelpInfoMenuItem_Click);
            // 
            // AboutInfoMenuItem
            // 
            this.AboutInfoMenuItem.Name = "AboutInfoMenuItem";
            resources.ApplyResources(this.AboutInfoMenuItem, "AboutInfoMenuItem");
            this.AboutInfoMenuItem.Click += new System.EventHandler(this.AboutInfoMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "cmpx";
            this.openFileDialog1.FileName = "Vertexes.cmpx";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cmpx";
            this.saveFileDialog1.FileName = "Vertexes";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.InitialDirectory = "C:\\";
            // 
            // OutputBox
            // 
            resources.ApplyResources(this.OutputBox, "OutputBox");
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            // 
            // CalculateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.VertexesBox);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.DeletePoint);
            this.Controls.Add(this.YInputBox);
            this.Controls.Add(this.ZInputBox);
            this.Controls.Add(this.XInputBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(CalculateForm_KeyDown);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalculateForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XInputBox;
        private System.Windows.Forms.TextBox ZInputBox;
        private System.Windows.Forms.TextBox YInputBox;
        private System.Windows.Forms.Button DeletePoint;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ListBox VertexesBox;
        private System.Windows.Forms.RichTextBox ProgramName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadVertexesFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveVertexesFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectColorsViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectSizesViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPointOperationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePointOperationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateOperationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutInfoMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox OutputBox;
    }
}


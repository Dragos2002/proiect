namespace pr
{
    partial class TehnologiaInformatiei
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
            menuStrip1 = new MenuStrip();
            aniDeStudiuToolStripMenuItem = new ToolStripMenuItem();
            anul1ToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aniDeStudiuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aniDeStudiuToolStripMenuItem
            // 
            aniDeStudiuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anul1ToolStripMenuItem });
            aniDeStudiuToolStripMenuItem.Name = "aniDeStudiuToolStripMenuItem";
            aniDeStudiuToolStripMenuItem.Size = new Size(112, 24);
            aniDeStudiuToolStripMenuItem.Text = "Ani de Studiu";
            aniDeStudiuToolStripMenuItem.Click += aniDeStudiuToolStripMenuItem_Click;
            // 
            // anul1ToolStripMenuItem
            // 
            anul1ToolStripMenuItem.Name = "anul1ToolStripMenuItem";
            anul1ToolStripMenuItem.Size = new Size(224, 26);
            anul1ToolStripMenuItem.Text = "Anul I";
            anul1ToolStripMenuItem.Click += anul1ToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(326, 145);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Inapoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TehnologiaInformatiei
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TehnologiaInformatiei";
            Text = "TehnologiaInformatiei";
            Load += TehnologiaInformatiei_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aniDeStudiuToolStripMenuItem;
        private ToolStripMenuItem anul1ToolStripMenuItem;
        private Button button1;
    }
}
using System.Data.SqlClient;

namespace pr
{
    partial class Automatica
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
            anulIToolStripMenuItem = new ToolStripMenuItem();
            grupaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            tbP = new TextBox();
            tbIT = new TextBox();
            tbCNP = new TextBox();
            tbDI = new TextBox();
            tbCI = new TextBox();
            tbN = new TextBox();
            tbNM = new TextBox();
            tbM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aniDeStudiuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1383, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aniDeStudiuToolStripMenuItem
            // 
            aniDeStudiuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anulIToolStripMenuItem });
            aniDeStudiuToolStripMenuItem.Name = "aniDeStudiuToolStripMenuItem";
            aniDeStudiuToolStripMenuItem.Size = new Size(112, 24);
            aniDeStudiuToolStripMenuItem.Text = "Ani de Studiu";
            // 
            // anulIToolStripMenuItem
            // 
            anulIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grupaToolStripMenuItem });
            anulIToolStripMenuItem.Name = "anulIToolStripMenuItem";
            anulIToolStripMenuItem.Size = new Size(130, 26);
            anulIToolStripMenuItem.Text = "Anul I";
            // 
            // grupaToolStripMenuItem
            // 
            grupaToolStripMenuItem.Name = "grupaToolStripMenuItem";
            grupaToolStripMenuItem.Size = new Size(136, 26);
            grupaToolStripMenuItem.Text = "Grupa ";
            // 
            // button1
            // 
            button1.Location = new Point(0, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Inapoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbP
            // 
            tbP.Location = new Point(205, 205);
            tbP.Name = "tbP";
            tbP.Size = new Size(155, 27);
            tbP.TabIndex = 2;
            // 
            // tbIT
            // 
            tbIT.Location = new Point(205, 249);
            tbIT.Name = "tbIT";
            tbIT.Size = new Size(155, 27);
            tbIT.TabIndex = 3;
            // 
            // tbCNP
            // 
            tbCNP.Location = new Point(205, 296);
            tbCNP.Name = "tbCNP";
            tbCNP.Size = new Size(155, 27);
            tbCNP.TabIndex = 4;
            // 
            // tbDI
            // 
            tbDI.Location = new Point(205, 339);
            tbDI.Name = "tbDI";
            tbDI.Size = new Size(155, 27);
            tbDI.TabIndex = 5;
            tbDI.TextChanged += textBox4_TextChanged;
            // 
            // tbCI
            // 
            tbCI.Location = new Point(205, 385);
            tbCI.Name = "tbCI";
            tbCI.Size = new Size(155, 27);
            tbCI.TabIndex = 6;
            // 
            // tbN
            // 
            tbN.Location = new Point(205, 158);
            tbN.Name = "tbN";
            tbN.Size = new Size(155, 27);
            tbN.TabIndex = 7;
            // 
            // tbNM
            // 
            tbNM.Location = new Point(205, 115);
            tbNM.Name = "tbNM";
            tbNM.Size = new Size(155, 27);
            tbNM.TabIndex = 8;
            tbNM.TextChanged += textBox7_TextChanged;
            // 
            // tbM
            // 
            tbM.Location = new Point(205, 430);
            tbM.Name = "tbM";
            tbM.Size = new Size(155, 27);
            tbM.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 121);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 10;
            label1.Text = "Nr matricol";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 161);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 11;
            label2.Text = "Nume";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 208);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 12;
            label3.Text = "Prenume";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 252);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 13;
            label4.Text = "Initiala tatalui";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 299);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 14;
            label5.Text = "CNP";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 342);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 15;
            label6.Text = "Data inscrierii";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 388);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 16;
            label7.Text = "Ciclu invatamant";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 433);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 17;
            label8.Text = "Media";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(523, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(692, 439);
            dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(154, 515);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Automatica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 662);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbM);
            Controls.Add(tbNM);
            Controls.Add(tbN);
            Controls.Add(tbCI);
            Controls.Add(tbDI);
            Controls.Add(tbCNP);
            Controls.Add(tbIT);
            Controls.Add(tbP);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Automatica";
            Text = "Automatica";
            Load += Automatica_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aniDeStudiuToolStripMenuItem;
        private ToolStripMenuItem anulIToolStripMenuItem;
        private ToolStripMenuItem grupaToolStripMenuItem;
        private Button button1;
        private TextBox tbP;
        private TextBox tbIT;
        private TextBox tbCNP;
        private TextBox tbDI;
        private TextBox tbCI;
        private TextBox tbN;
        private TextBox tbNM;
        private TextBox tbM;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
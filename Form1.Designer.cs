namespace LW2Graphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            StartLabel = new Label();
            menuStrip1 = new MenuStrip();
            выбратToolStripMenuItem = new ToolStripMenuItem();
            changePositionToolStripMenuItem = new ToolStripMenuItem();
            flipObjectToolStripMenuItem = new ToolStripMenuItem();
            changeSizeОбъектToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(StartLabel);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(859, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 715);
            panel1.TabIndex = 0;
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            StartLabel.Location = new Point(79, 111);
            StartLabel.MaximumSize = new Size(200, 0);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(195, 104);
            StartLabel.TabIndex = 1;
            StartLabel.Text = "Выберите действие, которое необходимо выполнить";
            StartLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { выбратToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(350, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выбратToolStripMenuItem
            // 
            выбратToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePositionToolStripMenuItem, flipObjectToolStripMenuItem, changeSizeОбъектToolStripMenuItem });
            выбратToolStripMenuItem.Name = "выбратToolStripMenuItem";
            выбратToolStripMenuItem.Size = new Size(108, 20);
            выбратToolStripMenuItem.Text = "Выбор действия";
            // 
            // changePositionToolStripMenuItem
            // 
            changePositionToolStripMenuItem.Name = "changePositionToolStripMenuItem";
            changePositionToolStripMenuItem.Size = new Size(204, 22);
            changePositionToolStripMenuItem.Text = "Передвинуть объект";
            // 
            // flipObjectToolStripMenuItem
            // 
            flipObjectToolStripMenuItem.Name = "flipObjectToolStripMenuItem";
            flipObjectToolStripMenuItem.Size = new Size(204, 22);
            flipObjectToolStripMenuItem.Text = "Повернуть объект";
            // 
            // changeSizeОбъектToolStripMenuItem
            // 
            changeSizeОбъектToolStripMenuItem.Name = "changeSizeОбъектToolStripMenuItem";
            changeSizeОбъектToolStripMenuItem.Size = new Size(204, 22);
            changeSizeОбъектToolStripMenuItem.Text = "Сжать (разжать) объект";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 715);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ЛР2 Никончук ВИ КЭ-243";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выбратToolStripMenuItem;
        private ToolStripMenuItem changePositionToolStripMenuItem;
        private ToolStripMenuItem flipObjectToolStripMenuItem;
        private ToolStripMenuItem changeSizeОбъектToolStripMenuItem;
        private Label StartLabel;
    }
}

namespace 成绩管理
{
    partial class StuForm1
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
            系统与用户UToolStripMenuItem = new ToolStripMenuItem();
            修改密码ToolStripMenuItem = new ToolStripMenuItem();
            退出系统ToolStripMenuItem = new ToolStripMenuItem();
            成绩管理GToolStripMenuItem = new ToolStripMenuItem();
            学生选课ToolStripMenuItem = new ToolStripMenuItem();
            查看成绩ToolStripMenuItem = new ToolStripMenuItem();
            帮助HToolStripMenuItem = new ToolStripMenuItem();
            查看帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于本系统ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统与用户UToolStripMenuItem, 成绩管理GToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1090, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统与用户UToolStripMenuItem
            // 
            系统与用户UToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 修改密码ToolStripMenuItem, 退出系统ToolStripMenuItem });
            系统与用户UToolStripMenuItem.Name = "系统与用户UToolStripMenuItem";
            系统与用户UToolStripMenuItem.Size = new Size(141, 28);
            系统与用户UToolStripMenuItem.Text = "系统与用户(U)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Image = Properties.Resources.ChangePassword;
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(270, 34);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 退出系统ToolStripMenuItem
            // 
            退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            退出系统ToolStripMenuItem.Size = new Size(270, 34);
            退出系统ToolStripMenuItem.Text = "退出系统";
            退出系统ToolStripMenuItem.Click += 退出系统ToolStripMenuItem_Click;
            // 
            // 成绩管理GToolStripMenuItem
            // 
            成绩管理GToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 学生选课ToolStripMenuItem, 查看成绩ToolStripMenuItem });
            成绩管理GToolStripMenuItem.Name = "成绩管理GToolStripMenuItem";
            成绩管理GToolStripMenuItem.Size = new Size(123, 28);
            成绩管理GToolStripMenuItem.Text = "成绩管理(G)";
            // 
            // 学生选课ToolStripMenuItem
            // 
            学生选课ToolStripMenuItem.Image = Properties.Resources.Select;
            学生选课ToolStripMenuItem.Name = "学生选课ToolStripMenuItem";
            学生选课ToolStripMenuItem.Size = new Size(270, 34);
            学生选课ToolStripMenuItem.Text = "学生选课";
            学生选课ToolStripMenuItem.Click += 学生选课ToolStripMenuItem_Click;
            // 
            // 查看成绩ToolStripMenuItem
            // 
            查看成绩ToolStripMenuItem.Image = Properties.Resources.Find;
            查看成绩ToolStripMenuItem.Name = "查看成绩ToolStripMenuItem";
            查看成绩ToolStripMenuItem.Size = new Size(270, 34);
            查看成绩ToolStripMenuItem.Text = "查看成绩";
            查看成绩ToolStripMenuItem.Click += 查看成绩ToolStripMenuItem_Click;
            // 
            // 帮助HToolStripMenuItem
            // 
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 查看帮助ToolStripMenuItem, 关于本系统ToolStripMenuItem });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(88, 28);
            帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            查看帮助ToolStripMenuItem.Size = new Size(270, 34);
            查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // 关于本系统ToolStripMenuItem
            // 
            关于本系统ToolStripMenuItem.Name = "关于本系统ToolStripMenuItem";
            关于本系统ToolStripMenuItem.Size = new Size(270, 34);
            关于本系统ToolStripMenuItem.Text = "关于本系统";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1090, 33);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.ChangePassword;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.Find;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(34, 28);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.Select;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(34, 28);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 667);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1090, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 15);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.屏幕截图_2023_12_22_182727;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // StuForm1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 689);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "StuForm1";
            Text = "成绩管理系统(学生端)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统与用户UToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 退出系统ToolStripMenuItem;
        private ToolStripMenuItem 成绩管理GToolStripMenuItem;
        private ToolStripMenuItem 学生选课ToolStripMenuItem;
        private ToolStripMenuItem 查看成绩ToolStripMenuItem;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于本系统ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
    }
}
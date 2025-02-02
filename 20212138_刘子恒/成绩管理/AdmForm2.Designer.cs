namespace 成绩管理
{
    partial class AdmForm2
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
            系统与ToolStripMenuItem = new ToolStripMenuItem();
            修改密码ToolStripMenuItem = new ToolStripMenuItem();
            添加教务员ToolStripMenuItem = new ToolStripMenuItem();
            删除教务员ToolStripMenuItem = new ToolStripMenuItem();
            退出系统ToolStripMenuItem = new ToolStripMenuItem();
            学生管理SToolStripMenuItem = new ToolStripMenuItem();
            添加学生ToolStripMenuItem = new ToolStripMenuItem();
            删改学生ToolStripMenuItem = new ToolStripMenuItem();
            课程管理CToolStripMenuItem = new ToolStripMenuItem();
            添加课程ToolStripMenuItem = new ToolStripMenuItem();
            删改课程ToolStripMenuItem = new ToolStripMenuItem();
            成绩管理GToolStripMenuItem = new ToolStripMenuItem();
            录入成绩ToolStripMenuItem = new ToolStripMenuItem();
            查看成绩ToolStripMenuItem = new ToolStripMenuItem();
            帮助HToolStripMenuItem = new ToolStripMenuItem();
            查看帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于本系统ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统与ToolStripMenuItem, 学生管理SToolStripMenuItem, 课程管理CToolStripMenuItem, 成绩管理GToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1220, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统与ToolStripMenuItem
            // 
            系统与ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 修改密码ToolStripMenuItem, 添加教务员ToolStripMenuItem, 删除教务员ToolStripMenuItem, 退出系统ToolStripMenuItem });
            系统与ToolStripMenuItem.Name = "系统与ToolStripMenuItem";
            系统与ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            系统与ToolStripMenuItem.Size = new Size(141, 28);
            系统与ToolStripMenuItem.Text = "系统与用户(U)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Image = Properties.Resources.ChangePassword;
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(270, 34);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 添加教务员ToolStripMenuItem
            // 
            添加教务员ToolStripMenuItem.Name = "添加教务员ToolStripMenuItem";
            添加教务员ToolStripMenuItem.Size = new Size(270, 34);
            添加教务员ToolStripMenuItem.Text = "添加教务员";
            添加教务员ToolStripMenuItem.Click += 添加教务员ToolStripMenuItem_Click;
            // 
            // 删除教务员ToolStripMenuItem
            // 
            删除教务员ToolStripMenuItem.Name = "删除教务员ToolStripMenuItem";
            删除教务员ToolStripMenuItem.Size = new Size(270, 34);
            删除教务员ToolStripMenuItem.Text = "删除教务员";
            // 
            // 退出系统ToolStripMenuItem
            // 
            退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            退出系统ToolStripMenuItem.Size = new Size(270, 34);
            退出系统ToolStripMenuItem.Text = "退出系统";
            退出系统ToolStripMenuItem.Click += 退出系统ToolStripMenuItem_Click;
            // 
            // 学生管理SToolStripMenuItem
            // 
            学生管理SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加学生ToolStripMenuItem, 删改学生ToolStripMenuItem });
            学生管理SToolStripMenuItem.Name = "学生管理SToolStripMenuItem";
            学生管理SToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            学生管理SToolStripMenuItem.Size = new Size(120, 28);
            学生管理SToolStripMenuItem.Text = "学生管理(S)";
            // 
            // 添加学生ToolStripMenuItem
            // 
            添加学生ToolStripMenuItem.Image = Properties.Resources.AddItems;
            添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            添加学生ToolStripMenuItem.Size = new Size(270, 34);
            添加学生ToolStripMenuItem.Text = "添加学生";
            添加学生ToolStripMenuItem.Click += 添加学生ToolStripMenuItem_Click;
            // 
            // 删改学生ToolStripMenuItem
            // 
            删改学生ToolStripMenuItem.Image = Properties.Resources.Delete;
            删改学生ToolStripMenuItem.Name = "删改学生ToolStripMenuItem";
            删改学生ToolStripMenuItem.Size = new Size(270, 34);
            删改学生ToolStripMenuItem.Text = "删改学生";
            删改学生ToolStripMenuItem.Click += 删改学生ToolStripMenuItem_Click;
            // 
            // 课程管理CToolStripMenuItem
            // 
            课程管理CToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加课程ToolStripMenuItem, 删改课程ToolStripMenuItem });
            课程管理CToolStripMenuItem.Name = "课程管理CToolStripMenuItem";
            课程管理CToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            课程管理CToolStripMenuItem.Size = new Size(122, 28);
            课程管理CToolStripMenuItem.Text = "课程管理(C)";
            // 
            // 添加课程ToolStripMenuItem
            // 
            添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            添加课程ToolStripMenuItem.Size = new Size(270, 34);
            添加课程ToolStripMenuItem.Text = "添加课程";
            // 
            // 删改课程ToolStripMenuItem
            // 
            删改课程ToolStripMenuItem.Name = "删改课程ToolStripMenuItem";
            删改课程ToolStripMenuItem.Size = new Size(270, 34);
            删改课程ToolStripMenuItem.Text = "删改课程";
            // 
            // 成绩管理GToolStripMenuItem
            // 
            成绩管理GToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 录入成绩ToolStripMenuItem, 查看成绩ToolStripMenuItem });
            成绩管理GToolStripMenuItem.Name = "成绩管理GToolStripMenuItem";
            成绩管理GToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            成绩管理GToolStripMenuItem.Size = new Size(123, 28);
            成绩管理GToolStripMenuItem.Text = "成绩管理(G)";
            // 
            // 录入成绩ToolStripMenuItem
            // 
            录入成绩ToolStripMenuItem.Name = "录入成绩ToolStripMenuItem";
            录入成绩ToolStripMenuItem.Size = new Size(270, 34);
            录入成绩ToolStripMenuItem.Text = "录入成绩";
            录入成绩ToolStripMenuItem.Click += 录入成绩ToolStripMenuItem_Click;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1220, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.ChangePassword;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.AddItems;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Delete;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 745);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1220, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.屏幕截图_2023_12_22_182727;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1220, 674);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AdmForm2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 767);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdmForm2";
            Text = "成绩管理系统";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统与ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 添加教务员ToolStripMenuItem;
        private ToolStripMenuItem 删除教务员ToolStripMenuItem;
        private ToolStripMenuItem 退出系统ToolStripMenuItem;
        private ToolStripMenuItem 学生管理SToolStripMenuItem;
        private ToolStripMenuItem 添加学生ToolStripMenuItem;
        private ToolStripMenuItem 删改学生ToolStripMenuItem;
        private ToolStripMenuItem 课程管理CToolStripMenuItem;
        private ToolStripMenuItem 添加课程ToolStripMenuItem;
        private ToolStripMenuItem 删改课程ToolStripMenuItem;
        private ToolStripMenuItem 成绩管理GToolStripMenuItem;
        private ToolStripMenuItem 录入成绩ToolStripMenuItem;
        private ToolStripMenuItem 查看成绩ToolStripMenuItem;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于本系统ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private StatusStrip statusStrip1;
        private PictureBox pictureBox1;
    }
}
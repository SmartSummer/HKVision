namespace HkVision
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BASE_Operator = new System.Windows.Forms.GroupBox();
            this.BX_Start = new System.Windows.Forms.Button();
            this.Capture_BMP = new System.Windows.Forms.Button();
            this.BX_Record = new System.Windows.Forms.Button();
            this.BASE_Group = new System.Windows.Forms.GroupBox();
            this.BX_UserSet = new System.Windows.Forms.Button();
            this.BX_ImageSet = new System.Windows.Forms.Button();
            this.BX_ALLScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BX_ChanleSet = new System.Windows.Forms.ComboBox();
            this.Capture_JPEG = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BASE_Operator.SuspendLayout();
            this.BASE_Group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.BASE_Operator);
            this.panel1.Controls.Add(this.BASE_Group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 477);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 335);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "视窗";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 315);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
       
            this.pictureBox1.DoubleClick += new System.EventHandler(this.Pic_DoubleClick);
            // 
            // BASE_Operator
            // 
            this.BASE_Operator.AutoSize = true;
            this.BASE_Operator.Controls.Add(this.BX_Start);
            this.BASE_Operator.Controls.Add(this.Capture_BMP);
            this.BASE_Operator.Controls.Add(this.BX_Record);
            this.BASE_Operator.Controls.Add(this.Capture_JPEG);
            this.BASE_Operator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BASE_Operator.Location = new System.Drawing.Point(0, 421);
            this.BASE_Operator.Name = "BASE_Operator";
            this.BASE_Operator.Size = new System.Drawing.Size(958, 56);
            this.BASE_Operator.TabIndex = 10;
            this.BASE_Operator.TabStop = false;
            this.BASE_Operator.Text = "基本操作";
            // 
            // BX_Start
            // 
            this.BX_Start.Location = new System.Drawing.Point(6, 13);
            this.BX_Start.Name = "BX_Start";
            this.BX_Start.Size = new System.Drawing.Size(75, 23);
            this.BX_Start.TabIndex = 5;
            this.BX_Start.Text = "开始";
            this.BX_Start.UseVisualStyleBackColor = true;
            this.BX_Start.Click += new System.EventHandler(this.BX_Start_Click);
            // 
            // Capture_BMP
            // 
            this.Capture_BMP.Dock = System.Windows.Forms.DockStyle.Right;
            this.Capture_BMP.Location = new System.Drawing.Point(730, 17);
            this.Capture_BMP.Name = "Capture_BMP";
            this.Capture_BMP.Size = new System.Drawing.Size(75, 36);
            this.Capture_BMP.TabIndex = 6;
            this.Capture_BMP.Text = "截图BMP";
            this.Capture_BMP.UseVisualStyleBackColor = true;
            this.Capture_BMP.Click += new System.EventHandler(this.Capture_BMP_Click);
            // 
            // BX_Record
            // 
            this.BX_Record.Dock = System.Windows.Forms.DockStyle.Right;
            this.BX_Record.Location = new System.Drawing.Point(805, 17);
            this.BX_Record.Name = "BX_Record";
            this.BX_Record.Size = new System.Drawing.Size(75, 36);
            this.BX_Record.TabIndex = 8;
            this.BX_Record.Text = "录像";
            this.BX_Record.UseVisualStyleBackColor = true;
            this.BX_Record.Click += new System.EventHandler(this.BX_Record_Click);
            // 
            // BASE_Group
            // 
            this.BASE_Group.AutoSize = true;
            this.BASE_Group.Controls.Add(this.groupBox1);
            this.BASE_Group.Controls.Add(this.BX_UserSet);
            this.BASE_Group.Controls.Add(this.BX_ImageSet);
            this.BASE_Group.Controls.Add(this.BX_ALLScreen);
            this.BASE_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.BASE_Group.Location = new System.Drawing.Point(0, 0);
            this.BASE_Group.Name = "BASE_Group";
            this.BASE_Group.Size = new System.Drawing.Size(958, 86);
            this.BASE_Group.TabIndex = 11;
            this.BASE_Group.TabStop = false;
            this.BASE_Group.Text = "基本设置";
            // 
            // BX_UserSet
            // 
            this.BX_UserSet.AutoSize = true;
            this.BX_UserSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.BX_UserSet.Location = new System.Drawing.Point(3, 17);
            this.BX_UserSet.Name = "BX_UserSet";
            this.BX_UserSet.Size = new System.Drawing.Size(75, 66);
            this.BX_UserSet.TabIndex = 0;
            this.BX_UserSet.Text = "用户设置";
            this.BX_UserSet.UseVisualStyleBackColor = true;
            this.BX_UserSet.Click += new System.EventHandler(this.BX_UserSet_Click);
            // 
            // BX_ImageSet
            // 
            this.BX_ImageSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.BX_ImageSet.Location = new System.Drawing.Point(805, 17);
            this.BX_ImageSet.Name = "BX_ImageSet";
            this.BX_ImageSet.Size = new System.Drawing.Size(75, 66);
            this.BX_ImageSet.TabIndex = 1;
            this.BX_ImageSet.Text = "通道参数设置";
            this.BX_ImageSet.UseVisualStyleBackColor = true;
            this.BX_ImageSet.Click += new System.EventHandler(this.BX_ImageSet_Click);
            // 
            // BX_ALLScreen
            // 
            this.BX_ALLScreen.AutoSize = true;
            this.BX_ALLScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BX_ALLScreen.Location = new System.Drawing.Point(880, 17);
            this.BX_ALLScreen.Name = "BX_ALLScreen";
            this.BX_ALLScreen.Size = new System.Drawing.Size(75, 66);
            this.BX_ALLScreen.TabIndex = 9;
            this.BX_ALLScreen.Text = "全屏显示";
            this.BX_ALLScreen.UseVisualStyleBackColor = true;
            this.BX_ALLScreen.Click += new System.EventHandler(this.BX_ALLScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "通道号";
            // 
            // BX_ChanleSet
            // 
            this.BX_ChanleSet.FormattingEnabled = true;
            this.BX_ChanleSet.Location = new System.Drawing.Point(6, 21);
            this.BX_ChanleSet.Name = "BX_ChanleSet";
            this.BX_ChanleSet.Size = new System.Drawing.Size(121, 20);
            this.BX_ChanleSet.TabIndex = 3;
            // 
            // Capture_JPEG
            // 
            this.Capture_JPEG.Dock = System.Windows.Forms.DockStyle.Right;
            this.Capture_JPEG.Location = new System.Drawing.Point(880, 17);
            this.Capture_JPEG.Name = "Capture_JPEG";
            this.Capture_JPEG.Size = new System.Drawing.Size(75, 36);
            this.Capture_JPEG.TabIndex = 7;
            this.Capture_JPEG.Text = "截图JPEG";
            this.Capture_JPEG.UseVisualStyleBackColor = true;
            this.Capture_JPEG.Click += new System.EventHandler(this.Capture_JPEG_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BX_ChanleSet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(84, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道参数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 477);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "监控软件";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BASE_Operator.ResumeLayout(false);
            this.BASE_Group.ResumeLayout(false);
            this.BASE_Group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BX_ImageSet;
        private System.Windows.Forms.Button BX_UserSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BX_ChanleSet;
        private System.Windows.Forms.Button Capture_BMP;
        private System.Windows.Forms.Button BX_Start;
        private System.Windows.Forms.Button BX_Record;
        private System.Windows.Forms.Button BX_ALLScreen;
        private System.Windows.Forms.GroupBox BASE_Operator;
        private System.Windows.Forms.GroupBox BASE_Group;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Capture_JPEG;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


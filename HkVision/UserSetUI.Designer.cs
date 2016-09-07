namespace HkVision
{
    partial class UserSetUI
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
            this.Text_IPAddress = new System.Windows.Forms.TextBox();
            this.Text_Port = new System.Windows.Forms.TextBox();
            this.Text_UserName = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BX_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_IPAddress
            // 
            this.Text_IPAddress.Location = new System.Drawing.Point(92, 39);
            this.Text_IPAddress.Name = "Text_IPAddress";
            this.Text_IPAddress.Size = new System.Drawing.Size(100, 21);
            this.Text_IPAddress.TabIndex = 0;
            this.Text_IPAddress.Text = "192.168.1.254";
            // 
            // Text_Port
            // 
            this.Text_Port.Location = new System.Drawing.Point(310, 39);
            this.Text_Port.Name = "Text_Port";
            this.Text_Port.Size = new System.Drawing.Size(100, 21);
            this.Text_Port.TabIndex = 1;
            this.Text_Port.Text = "8000";
            // 
            // Text_UserName
            // 
            this.Text_UserName.Location = new System.Drawing.Point(92, 91);
            this.Text_UserName.Name = "Text_UserName";
            this.Text_UserName.Size = new System.Drawing.Size(100, 21);
            this.Text_UserName.TabIndex = 2;
            this.Text_UserName.Text = "admin";
            // 
            // Text_Password
            // 
            this.Text_Password.Location = new System.Drawing.Point(310, 91);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '*';
            this.Text_Password.Size = new System.Drawing.Size(100, 21);
            this.Text_Password.TabIndex = 3;
            this.Text_Password.Text = "12345";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "相机IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "相机端口";
            // 
            // BX_Login
            // 
            this.BX_Login.Location = new System.Drawing.Point(92, 140);
            this.BX_Login.Name = "BX_Login";
            this.BX_Login.Size = new System.Drawing.Size(75, 23);
            this.BX_Login.TabIndex = 8;
            this.BX_Login.Text = "登陆";
            this.BX_Login.UseVisualStyleBackColor = true;
            this.BX_Login.Click += new System.EventHandler(this.BX_Login_Click);
            // 
            // UserSetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 210);
            this.Controls.Add(this.BX_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Text_UserName);
            this.Controls.Add(this.Text_Port);
            this.Controls.Add(this.Text_IPAddress);
            this.Name = "UserSetUI";
            this.Text = "UserSetUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_IPAddress;
        private System.Windows.Forms.TextBox Text_Port;
        private System.Windows.Forms.TextBox Text_UserName;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BX_Login;
    }
}
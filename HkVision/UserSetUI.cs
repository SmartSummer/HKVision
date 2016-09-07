using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HkVision.EventDef;
using HkVision.Service;

namespace HkVision
{

  
    public partial class UserSetUI : Form
    {
        public  event SetInfo _si;
        public UserSetUI(SetInfo si)
        {
          
            InitializeComponent();
            _si = si;
        }


        private void BX_Login_Click(object sender, EventArgs e)
        {

            try
            {
                UserInfo user = new UserInfo();

                user.IPAddress = Text_IPAddress.Text.ToString().Trim();
                user.Port = Text_Port.Text.ToString().Trim();
                user.UserName = Text_UserName.Text.ToString().Trim();
                user.Password = Text_Password.Text.ToString().Trim();

                HKService hks = HKService.GetInstance();
                
                bool falg;
                int userID = hks.Login(user, out falg);
                if (falg == true)
                {

                    CommonConfig cc = new CommonConfig();
                    _si(cc);
                    MessageBox.Show("登陆成功");
                    this.Close();
                }
                else {

                    MessageBox.Show("登陆失败");
                }
            }
            catch (Exception eee) {

                MessageBox.Show("输入有误");
            }

        }


        
    }
}

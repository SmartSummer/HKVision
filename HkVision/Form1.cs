using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HkVision.EventDef;
using System.IO;
using HkVision.Service;
using HkVision.Utils;

namespace HkVision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            si = new SetInfo(CallBackUserInfo);
            
            hks = HKService.GetInstance();
            InitalData();
        }

        void InitalData() {

            if (!Directory.Exists(ConfigService.CurrentPath)) {

                Directory.CreateDirectory(ConfigService.CurrentPath);
            }
            if (!Directory.Exists(ConfigService.CurrentFilePath))
            {

                Directory.CreateDirectory(ConfigService.CurrentFilePath);
            }

        }
        private void BX_Start_Click(object sender, EventArgs e)
        {
            uint errcode = 8888;
            try
            {
                bool flag = hks.StartCapture(pictureBox1.Handle, 1, out errcode);

                if (!flag) {

                    MessageBox.Show("error Code : = " + errcode);
                }
            }
            catch (Exception ee) {

                MessageBox.Show("先连接服务器 : = " + errcode);
            }
        }

        private void BX_UserSet_Click(object sender, EventArgs e)
        {
            UserSetUI usi = new UserSetUI(si);
            usi.ShowDialog();
        }


        private  void CallBackUserInfo(object ob) {

            hks.UpDataCHannle(this.BX_ChanleSet);

        }
        event SetInfo si;
        private HKService hks;

        private void BX_ImageSet_Click(object sender, EventArgs e)
        {
            ChanConfig dlg = new ChanConfig();
            dlg.m_lUserID = hks.GetUserID();

            if ((dlg.m_lUserID < 0) || (BX_ChanleSet.SelectedIndex < 0))
            {
                MessageBox.Show("请先登录设备获取通道！");
                return;
            }

            if (BX_ChanleSet.SelectedIndex < 0)
            {
                MessageBox.Show("没有获取到设备通道！");
                return;
            }

            dlg.m_lChannel =  hks.SelectChannel(BX_ChanleSet.SelectedIndex);
            dlg.m_struDeviceInfo = hks.GetDeviceInfo();
            dlg.ShowDialog();
        }

        private bool _flag_Record;
        private void BX_Record_Click(object sender, EventArgs e)
        {
            try {

                if (_flag_Record == false)
                {
                    string strDate = System.DateTime.Now.ToString("yyyyMMddhhmmss");
                    string path = ConfigService.CurrentPath + "record-"+strDate+".mp4";

                    bool flag = hks.StartRecoed(path);
                    if (!flag)
                    {

                        MessageBox.Show("录像失败");
                    }
                    else
                    {

                        this.BX_Record.Text = "停止";
                        _flag_Record = true;
                    }
                }
                else {

                    bool flag = hks.StopRecord();
                    if (!flag)
                    {

                        MessageBox.Show("录像失败");
                    }
                    else
                    {

                        this.BX_Record.Text = "录像";
                        _flag_Record = false;
                    }

                }

            }
            catch (Exception eee) {

                MessageBox.Show("确认相机已打开");
            }
        }

        private void Capture_BMP_Click(object sender, EventArgs e)
        {
            try
            {
                string strDate = System.DateTime.Now.ToString("yyyyMMddhhmmss");
                string path = ConfigService.CurrentFilePath + "record-" + strDate + ".bmp";
                if(!hks.CaputereBMP(path))
                    MessageBox.Show("截图BMP失败");

            }
            catch (Exception ee) {
                MessageBox.Show("截图BMP失败");

            }
        }

        private void Capture_JPEG_Click(object sender, EventArgs e)
        {
            try
            {
                string strDate = System.DateTime.Now.ToString("yyyyMMddhhmmss");
                string path = ConfigService.CurrentFilePath + "record-" + strDate + ".jpeg";
                if(!hks.CaputereJPEG(path))
                    MessageBox.Show("截图JPEG失败");
            }
            catch (Exception ee)
            {

                MessageBox.Show("截图JPEG失败");
            }
        }

        private void BX_ALLScreen_Click(object sender, EventArgs e)
        {
            isAll = !isAll;
            this.BASE_Group.Visible = false;
            this.BASE_Operator.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(Screen.GetWorkingArea(this).Width, Screen.GetWorkingArea(this).Height); 
            this.WindowState = FormWindowState.Maximized;
        }

      

        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            if (isAll)
            {

                //WindowScreenUtils.Click(this);
                this.BASE_Group.Visible = true;
                this.BASE_Operator.Visible = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                this.WindowState = FormWindowState.Normal;
            }
            else {

                //WindowScreenUtils.Click(this);
                this.BASE_Group.Visible = false;
                this.BASE_Operator.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               // this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.ClientSize = new System.Drawing.Size(Screen.GetWorkingArea(this).Width, Screen.GetWorkingArea(this).Height); ;
                this.WindowState = FormWindowState.Maximized;
            }
            isAll = !isAll;
        }


        private bool isAll;

       
    }
} 

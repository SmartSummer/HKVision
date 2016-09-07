using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HKBaseDLL;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HkVision.Service
{
    public class HKService
    {

        private CHCNetSDK.NET_DVR_DEVICEINFO_V30 m_struDeviceInfo;
        private CHAN_INFO m_struChanNoInfo = new CHAN_INFO();
        private int m_lUserID;
        private int m_lRealHandle;
        private int CurrentChannel;
        private IntPtr CurrentHandle;
        private CHCNetSDK.NET_DVR_IPPARACFG_V40 m_struIpParaCfgV40;
        #region GetMethod

        public int GetUserID()
        {

            return m_lUserID;
        }

        public int GetHandle()
        {

            return m_lRealHandle;
        }

        public int GetChannel()
        {

            return CurrentChannel;
        }

        public IntPtr GetWindowHandle()
        {

            return CurrentHandle;
        }

        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 GetDeviceInfo() { return m_struDeviceInfo; }

        #endregion
        private static HKService hks;

        public static HKService GetInstance()
        {

            if (hks == null)
            {

                hks = new HKService();
            }
            return hks;
        }

        private HKService()
        {

            m_lUserID = -1;
            m_lRealHandle = -1;
            CurrentChannel = -1;
            CurrentHandle = IntPtr.Zero;

           bool  m_bInitSDK = CHCNetSDK.NET_DVR_Init();

           if (!m_bInitSDK) {

               System.Windows.Forms.MessageBox.Show("库初始化失败");
           }
        }

        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="user"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public int Login(UserInfo user, out bool flag)
        {

            string DVRIPAddress = user.IPAddress; //设备IP地址或者域名
            Int16 DVRPortNumber = Int16.Parse(user.Port);//设备服务端口号
            string DVRUserName = user.UserName;//设备登录用户名
            string DVRPassword = user.Password;//设备登录密码

            m_struDeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();
            m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref m_struDeviceInfo);
            flag = false;
            if (m_lUserID < 0)
            {


                return (int)CHCNetSDK.NET_DVR_GetLastError();
            }

            flag = true;
            return m_lUserID;
        }

        /// <summary>
        /// 监控启动检测
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="chanel"></param>
        /// <returns></returns>
        public bool StartCapture(IntPtr handle, int chanel,out uint errorCode)
        {
            errorCode = 8888;
            if (m_lUserID < 0)
                return false;
            if (m_lRealHandle > 0)
                return true;

            CurrentChannel = chanel;

            CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
            lpPreviewInfo.hPlayWnd = handle;//预览窗口
            lpPreviewInfo.lChannel = chanel;//预te览的设备通道
            lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
            lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
            lpPreviewInfo.dwDisplayBufNum = 15; //播放库播放缓冲区最大缓冲帧数

            //CHCNetSDK.REALDATACALLBACK RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数
            IntPtr pUser = new IntPtr();//用户数据

            //打开预览 Start live view 
            //m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);

            m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null, pUser);

            if (m_lRealHandle < 0)
            {
                errorCode = CHCNetSDK.NET_DVR_GetLastError();
                return false;
            }

            CurrentHandle = handle;
            CurrentChannel = chanel;
            return true;
        }

        public bool StopCapture()
        {

            if (m_lUserID < 0)
                return false;

            if (m_lRealHandle < 0)
                return true;

            if (CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
            {

                return true;
            }
            return false;
        }

        public bool CaputereBMP(string path)
        {


            //BMP抓图 Capture a BMP picture
            if (CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle, path))
            {

                return true;
            }
            return false;
        }


        public bool CaputereJPEG(string path)
        {

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 2- 4CIF，0xff- Auto(使用当前码流分辨率)，抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图 Capture a JPEG picture
            if (CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, CurrentChannel, ref lpJpegPara, path))
            {

                return true;
            }
            return false;
        }



        public void UpDataCHannle(ComboBox comboBoxChan) {

            int i = 0, j = 0;
            string str;
            m_struChanNoInfo.Init();

            if (m_struDeviceInfo.byIPChanNum > 0)
            {
                uint dwSize = (uint)Marshal.SizeOf(m_struIpParaCfgV40);

                IntPtr ptrIpParaCfgV40 = Marshal.AllocHGlobal((Int32)dwSize);
                Marshal.StructureToPtr(m_struIpParaCfgV40, ptrIpParaCfgV40, false);

                uint dwReturn = 0;
                if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_IPPARACFG_V40, -1, ptrIpParaCfgV40, dwSize, ref dwReturn))
                {
                    uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    string strErr = "NET_DVR_GET_IPPARACFG_V40 failed, error code= " + iLastErr;
                    //获取IP通道信息失败，输出错误号 Failed to Get IP Channel info and output the error code
                    MessageBox.Show(strErr);
                }
                else
                {
                    m_struIpParaCfgV40 = (CHCNetSDK.NET_DVR_IPPARACFG_V40)Marshal.PtrToStructure(ptrIpParaCfgV40, typeof(CHCNetSDK.NET_DVR_IPPARACFG_V40));

                    //获取可用的模拟通道
                    for (i = 0; i < m_struIpParaCfgV40.dwAChanNum; i++)
                    {
                        if (m_struIpParaCfgV40.byAnalogChanEnable[i] == 1)
                        {
                            str = String.Format("通道{0}", i + 1);
                            comboBoxChan.Items.Add(str);
                            m_struChanNoInfo.lChannelNo[j] = i + m_struDeviceInfo.byStartChan;
                            j++;
                        }
                    }

                    //获取在线的IP通道
                    byte byStreamType;
                    for (i = 0; i < m_struIpParaCfgV40.dwDChanNum; i++)
                    {
                        byStreamType = m_struIpParaCfgV40.struStreamMode[i].byGetStreamType;
                        CHCNetSDK.NET_DVR_STREAM_MODE m_struStreamMode = new CHCNetSDK.NET_DVR_STREAM_MODE();
                        dwSize = (uint)Marshal.SizeOf(m_struStreamMode);
                        switch (byStreamType)
                        {
                            //0- 直接从设备取流 0- get stream from device directly
                            case 0:
                                IntPtr ptrChanInfo = Marshal.AllocHGlobal((Int32)dwSize);
                                Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[i].uGetStream, ptrChanInfo, false);
                                CHCNetSDK.NET_DVR_IPCHANINFO m_struChanInfo = new CHCNetSDK.NET_DVR_IPCHANINFO();
                                m_struChanInfo = (CHCNetSDK.NET_DVR_IPCHANINFO)Marshal.PtrToStructure(ptrChanInfo, typeof(CHCNetSDK.NET_DVR_IPCHANINFO));

                                //列出IP通道 List the IP channel
                                if (m_struChanInfo.byEnable == 1)
                                {
                                    str = String.Format("IP通道{0}", i + 1);
                                    comboBoxChan.Items.Add(str);
                                    m_struChanNoInfo.lChannelNo[j] = i + (int)m_struIpParaCfgV40.dwStartDChan;
                                    j++;
                                }
                                Marshal.FreeHGlobal(ptrChanInfo);
                                break;
                            //6- 直接从设备取流扩展 6- get stream from device directly(extended)
                            case 6:
                                IntPtr ptrChanInfoV40 = Marshal.AllocHGlobal((Int32)dwSize);
                                Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[i].uGetStream, ptrChanInfoV40, false);
                                CHCNetSDK.NET_DVR_IPCHANINFO_V40 m_struChanInfoV40 = new CHCNetSDK.NET_DVR_IPCHANINFO_V40();
                                m_struChanInfoV40 = (CHCNetSDK.NET_DVR_IPCHANINFO_V40)Marshal.PtrToStructure(ptrChanInfoV40, typeof(CHCNetSDK.NET_DVR_IPCHANINFO_V40));

                                //列出IP通道 List the IP channel
                                if (m_struChanInfoV40.byEnable == 1)
                                {
                                    str = String.Format("IP通道{0}", i + 1);
                                    comboBoxChan.Items.Add(str);
                                    m_struChanNoInfo.lChannelNo[j] = i + (int)m_struIpParaCfgV40.dwStartDChan;
                                    j++;
                                }
                                Marshal.FreeHGlobal(ptrChanInfoV40);
                                break;
                            default:
                                break;
                        }
                    }
                }
                Marshal.FreeHGlobal(ptrIpParaCfgV40);
            }
            else
            {
                for (i = 0; i < m_struDeviceInfo.byChanNum; i++)
                {
                    str = String.Format("通道{0}", i + 1);
                    comboBoxChan.Items.Add(str);
                    m_struChanNoInfo.lChannelNo[j] = i + m_struDeviceInfo.byStartChan;
                    j++;
                }
            }
            comboBoxChan.SelectedIndex = 0;

        }

        public int SelectChannel(int index) {


            return m_struChanNoInfo.lChannelNo[index];
           
        }

        public bool StartRecoed(string path) {

             CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, CurrentChannel);

             if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, path))
            {
                uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                string str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return false;
            }
            else
            {
               return true;
            }
        }

        public bool StopRecord() {

            if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
            {
                //iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                //str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                //MessageBox.Show(str);
                return false;
            }
            else
            {
                return true;
            }            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace HkVision
{
   public class CommonConfig
    {
       public int UserID { get; set; }
       public int Chanle { get; set; }
       public int Play_Handle { get; set; }

    }


   public class UserInfo {

       public string IPAddress { get; set; }
       public string Port { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
   
   }

   [StructLayoutAttribute(LayoutKind.Sequential)]
   public struct CHAN_INFO
   {
       [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.U4)]
       public Int32[] lChannelNo;
       public void Init()
       {
           lChannelNo = new Int32[256];
           for (int i = 0; i < 256; i++)
               lChannelNo[i] = -1;
       }
   }

}

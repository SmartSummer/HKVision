using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HkVision.Utils
{
   public class ConfigService
    {

       public static string CurrentPath = @".\zsq\";
       public static string CurrentFilePath = @".\image\";
       public static bool UpdateUserInfo(UserInfo user) {

           try
           {
               ConfigurationManager.AppSettings["UserName"] = user.UserName;
               ConfigurationManager.AppSettings["IPAddress"] = user.IPAddress;
               ConfigurationManager.AppSettings["Port"] = user.Port;
               ConfigurationManager.AppSettings["Password"] = user.Password;

               return true; 
           }
           catch (Exception e) {

               return false; 
           }
          
       }
    }



}

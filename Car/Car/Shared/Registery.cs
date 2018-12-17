using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Shared
{
   public static class  Registery
    {
      
            public static void SetIntKeys(string name, int value)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName, true);
                if (key != null)
                {
                    key.SetValue(name, value);
                    key.Close();
                }
                else
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Variables.AppName);
                    key.SetValue(name, value);
                    key.Close();
                }
            }

            public static int GetIntKeys(string name)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName);
                if (key != null && key.GetValue(name) != null)
                {
                    string res = key.GetValue(name).ToString();
                    return Convert.ToInt32(res);
                }
                else
                    return -1;
            }


        public static string GetConnectionString()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Program.AppName);
            if (key != null && key.GetValue("ConnectionString") != null)
                return key.GetValue("ConnectionString").ToString();
            else
                return "";
        }


        public static void SetConncetionString(string str)
        {

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Program.AppName, true);
            if (key != null)
            {
                key.SetValue("ConnectionString", str);

                key.Close();
            }
            else
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Program.AppName);
                key.SetValue("ConnectionString", str);

                key.Close();
            }
        }


        public static void SetActivationCode(string value)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName, true);
                if (key != null)
                {
                    key.SetValue("ActivationCode", value);
                    key.Close();
                }
                else
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Variables.AppName);
                    key.SetValue("ActivationCode", value);
                    key.Close();
                }
            }
            public static string GetActivationCode()
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName);
                if (key != null && key.GetValue("ActivationCode") != null)
                {
                    string res = key.GetValue("ActivationCode").ToString();
                    return res;
                }
                else
                    return "";
            }

            public static void RegisterApplicationDetail(string path, string version)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName, true);
                if (key != null)
                {
                    key.SetValue("Path", path);
                    key.SetValue("Version", version);
                    key.Close();
                }
                else
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Variables.AppName);
                    key.SetValue("Path", path);
                    key.SetValue("Version", version);
                    key.Close();
                }
            }
            public static void SetStringKeys(string name, string value)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName, true);
                if (key != null)
                {
                    key.SetValue(name, value);
                    key.Close();
                }
                else
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Variables.AppName);
                    key.SetValue(name, value);
                    key.Close();
                }
            }

            public static string GetStringKeys(string name)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Variables.AppName);
                if (key != null && key.GetValue(name) != null)
                    return key.GetValue(name).ToString();
                else
                    return "";
            }
        
    }
}

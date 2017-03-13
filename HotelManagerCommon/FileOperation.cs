using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using System.IO;
using System.Windows.Forms;
namespace HotelManagerCommon
{
    public class FileOperation
    {
        public void SavePassword(bool state,User user)
        {
            try
            {
                FileStream fs = new FileStream("HotelManagerInfo.dll", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                
                sw.WriteLine(user.UserName);
                sw.WriteLine(user.UserPass);
                sw.WriteLine(state);
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("文件写入异常!");
            }
            
        }
        public User LoadPassword()
        {
            User user = new User();
            try
            {
                if (File.Exists("HotelManagerInfo.dll"))
                {
                    FileStream fs = new FileStream("HotelManagerInfo.dll", FileMode.Open);
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    user.UserName = sr.ReadLine();
                    user.UserPass = sr.ReadLine();
                    user.State =Convert.ToBoolean(sr.ReadLine());
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    user = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("文件读取异常!");
            }
            return user;
        }
    }
}

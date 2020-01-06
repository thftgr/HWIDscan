using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace HWIDscan
{
    
    static class Program
    {

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //맥주소 받아오기
        public static string GetMac(int i)
        {
            StringBuilder SB = new StringBuilder();
            //string S1 = NetworkInterface.GetAllNetworkInterfaces()[i].GetIPv4Statistics().ToString();
            SB.Append(NetworkInterface.GetAllNetworkInterfaces()[i].Name.ToString());
            SB.Append(NetworkInterface.GetAllNetworkInterfaces()[i].GetPhysicalAddress().ToString());
            SB.Append(NetworkInterface.GetAllNetworkInterfaces()[i].Speed.ToString());
            







            return SB.ToString();
            //return i + ":  " + NetworkInterface.GetAllNetworkInterfaces()[i].GetPhysicalAddress().ToString();
        }

    }
}

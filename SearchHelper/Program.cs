using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchHelper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
    static class SearchEngines
    {
        public static void BuildURL(string Tartext)
        {
            BuildURL(Tartext, "baidu");
        }
        public static string BuildURL(string Tartext,string method)
        {
            string OpenBrowserCMD= "http://inkit.org";
            switch (method)
            {
                case "google":
                    OpenBrowserCMD = "http://www.google.com/search?q="+Tartext;
                    break;
                case "dictgoogle":
                    OpenBrowserCMD = "http://translate.google.com/#auto/zh-CN/"+Tartext;
                    break;
                case "googlesch":
                    OpenBrowserCMD = "http://scholar.google.com/scholar?q="+Tartext;
                    break;
                case "dictbaidu":
                    OpenBrowserCMD = "http://fanyi.baidu.com/#auto/zh/"+Tartext;
                    break;
                case "dictciba":
                    OpenBrowserCMD = "http://www.iciba.com/"+Tartext;
                    break;
                case "dictyoudao":
                    OpenBrowserCMD = "http://dict.youdao.com/search?q="+Tartext;
                    break;
                case "scihub":
                    OpenBrowserCMD = "http://sci-hub.cc/"+Tartext;
                    break;
                case "zhihu":
                    OpenBrowserCMD = "http://www.zhihu.com/search?type=content&q="+Tartext;
                    break;
                case "taobao":
                    OpenBrowserCMD = "http://s.taobao.com/search?_input_charset=utf-8&q=" + Tartext;
                    break;
                case "baidu":
                    OpenBrowserCMD = "http://www.baidu.com/baidu?word=" + Tartext;
                    break;
                default:
                    OpenBrowserCMD = "http://inkit.org";
                    break;
            }
            return OpenBrowserCMD;
        }
        public static void OpenURL(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}

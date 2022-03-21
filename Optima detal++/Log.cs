using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optima_detal__
{
    public class Log
    {
        public static void Error(string log)
        {
            try
            {
                if (Settings.Default.LogPath == "") return;
                StreamWriter sw = new StreamWriter(Settings.Default.LogPath + "\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "_Log.txt", true);
                using (sw)
                    sw.WriteLine(DateTime.Now.ToString() + " " + log + "\r\n");
            }
            catch (Exception ex)
            {

            }
        }

        public static void Info(string log)
        {
            StreamWriter sw = new StreamWriter(Settings.Default.LogPath + "\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "_Log.txt", true);
            using (sw)
                sw.WriteLine(DateTime.Now.ToString() + " " + log + "\r\n");
        }

        public static void Info2(string log)
        {
            StreamWriter sw = new StreamWriter(Settings.Default.LogPath + "\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "_LogImport.txt", true);
            using (sw)
                sw.WriteLine(DateTime.Now.ToString() + " " + log + "\r\n");
        }

        public static void AddUnmappedProductsToTxt(string log)
        {
            StreamWriter sw = new StreamWriter(Settings.Default.LogPath + "\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "_UnmappedProducts.txt", true);
            using (sw)
                sw.WriteLine(DateTime.Now.ToString() + " " + log + "\r\n");
        }
    }
}

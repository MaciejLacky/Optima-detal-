using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optima_detal__
{
    public class Methods
    {
        public static List<string> IsoEuKraje = new List<string>(new string[] {
            "AT", "BE", "BG", "HR", "CY", "CZ", "DK", "EE", "FI", "FR",
            "GR", "ES", "IE", "LT", "LU", "LV", "MT", "NL", "DE", "PT",
            "RO", "SK", "SI", "SE", "HU", "IT"
        });

        public static string GetSqlConnectionString()
        {
            string connectionString = "";
            if (Settings.Default.OptModulyUsera)
                return Settings.Default.SqlConnectionString;

            if (Settings.Default.WindowsAuth)
            {
                connectionString = "Data Source=" + Settings.Default.SqlServerName +
                          "; Initial Catalog = " + Settings.Default.SqlDatabaseName +
                          ";Integrated Security=True";
            }
            else
            {
                connectionString = "Data Source=" + Settings.Default.SqlServerName +
                         ";Initial Catalog=" + Settings.Default.SqlDatabaseName +
                         ";User ID=" + Settings.Default.SqlLogin +
                         ";Password=" + Settings.Default.SqlPassword;
            }
            return connectionString;
        }

        public static void Komunikat(TextBox textBox, string komunikat)
        {
            textBox.Text = komunikat;
            Application.DoEvents();
            System.Threading.Thread.Sleep(40);
        }

        public static void LoadLog4net()
        {
            if (Settings.Default.LogPath == "") return;

            GlobalContext.Properties["LogFileName"] = Settings.Default.LogPath + "\\"; //log file path
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.ConfigureAndWatch(logRepository, new FileInfo("log4net.config"));

        }

        public static byte[] GetBytes(SqlDataReader reader, int ordinal)
        {
            byte[] result = null;
            if (!reader.IsDBNull(ordinal))
            {
                long size = reader.GetBytes(ordinal, 0, null, 0, 0); //get the length of data 
                result = new byte[size];
                int bufferSize = 1024;
                long bytesRead = 0;
                int curPos = 0;
                while (bytesRead < size)
                {
                    bytesRead += reader.GetBytes(ordinal, curPos, result, curPos, bufferSize);
                    curPos += bufferSize;
                }
            }

            return result;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static int DateTimeToUnixTimeStamp(DateTime date)
        {
            return (Int32)(date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds - 7200;
        }

        public static Dictionary<string, string> vatValuesByIsoCode = new Dictionary<string, string>()
        {
            {"DE","19" }, {"EE","20" }, {"LU","17" }, {"SE","25" }, {"AT","20" }, {"FI","24" },
            {"LV","21" }, {"HU","27" }, {"BE","21" }, {"FR","20" }, {"MT","18" }, {"IT","22" },
            {"BG","20" }, {"GR","24" }, {"MC","20" }, {"HR","25" }, {"ES","21" }, {"PT","23" },
            {"CY","19" }, {"NL","21" }, {"RO","19" }, {"CZ","21" }, {"IE","23" }, {"SK","20" },
            {"DK","25" }, {"LT","21" }, {"SI","22" }, {"PL", "23"}
        };

        public static int GetIdTypeOfDocument(string typeDoc)
        {
            switch (typeDoc)
            {
                case "FZ":
                    return 301;
                case "FS":
                    return 302;
                case "WZ":
                    return 306;
                case "PZ":
                    return 307;
                case "RO":
                    return 308;
                case "RW":
                    return 304;
                case "PW":
                    return 303;
                case "PA":
                    return 305;
                case "FPF":
                    return 320;

                default:
                    return 0;
            }

        }
    }
}

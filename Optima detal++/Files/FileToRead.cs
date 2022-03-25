using Optima_detal__.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optima_detal__.Files
{
    public static class FileToRead
    {
        public static List<SpecialPriceModel> SpecialOfferFile(string filePath, TextBox tbLog)
        {
            List<SpecialPriceModel> docList = new List<SpecialPriceModel>();
            string result = "";
            if (string.IsNullOrEmpty(filePath)) return docList;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);
                using (sr)
                {
                    result = sr.ReadToEnd();
                    sr.Close();
                    tbLog.Text = "Wczytano plik poprawnie";
                }
            }
            catch (Exception ex)
            {
                Log.Error(" FileToRead.ReadFileToSettings() Problem z wczytaniem pliku" + ex.Message);
                tbLog.Text = "Brak pliku do pobrania."; 
            }

            result = result.Remove(0, Settings.Default.DeleteHeadingCharValue);           
            string[] rows = result.Split(Settings.Default.SaleSettingsColumnSeparatorNumber);
            int counter = 1;
            if (rows.Length == 0)
            {
                tbLog.Text = $"Problem z wczytaniem pliku. Nie mogę utworzyć listy z promocja. Sprawdź poprawność separatora i nagłówka";
                return docList;
            }
            foreach (var item in rows)
            {
                try
                {
                    var itemList = item.Split(new string[] { Settings.Default.SaleSettingsColumnSepColumn1, Settings.Default.SaleSettingsColumnSepColumn2 }, StringSplitOptions.RemoveEmptyEntries);
                    if (itemList.Length > (Settings.Default.SaleSettingsColumnPriceNumber > Settings.Default.SaleSettingsColumnCodeNumber ? Settings.Default.SaleSettingsColumnPriceNumber : Settings.Default.SaleSettingsColumnCodeNumber))
                        docList.Add(new SpecialPriceModel { codeItem = itemList[Settings.Default.SaleSettingsColumnCodeNumber], salePriceBrutto = itemList[Settings.Default.SaleSettingsColumnPriceNumber].Replace("b", "") });
                }
                catch (Exception)
                {
                    tbLog.Text = $"Problem z wczytaniem pliku w wierszu nr {counter}. {item}";
                }

            }
            tbLog.Text = $"Wczytano {docList.Count()} pozycji";
            return docList;
        }
        public static void ReadFileTest(string filePath, TextBox tbLog)
        {         
            string result = "";
            if (string.IsNullOrEmpty(filePath)) return;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);
                using (sr)
                {
                    result = sr.ReadToEnd();
                    sr.Close();
                    tbLog.Text = "Wczytano plik poprawnie";
                }
            }
            catch (Exception ex)
            {
                Log.Error(" FileToRead.ReadFileToSettings() Problem z wczytaniem pliku" + ex.Message);
                tbLog.Text = "Brak pliku do pobrania.";
            }

            result = result.Remove(0, Settings.Default.DeleteHeadingCharValue);
            string[] rows = result.Split(Settings.Default.SaleSettingsColumnSeparatorNumber);
            int counter = 1;
            if (rows.Length == 0)
            {
                tbLog.Text = $"Problem z wczytaniem pliku. Nie mogę utworzyć listy z promocja. Sprawdź poprawność separatora i nagłówka";
               
            }
            foreach (var item in rows.Take(2))
            {
                try
                {
                   tbLog.Text += "Wiersz" + Environment.NewLine;
                   tbLog.Text += item;
                    var itemList = item.Split(new string[] { Settings.Default.SaleSettingsColumnSepColumn1, Settings.Default.SaleSettingsColumnSepColumn2 }, StringSplitOptions.RemoveEmptyEntries);
                    if (itemList.Length > (Settings.Default.SaleSettingsColumnPriceNumber > Settings.Default.SaleSettingsColumnCodeNumber ? Settings.Default.SaleSettingsColumnPriceNumber : Settings.Default.SaleSettingsColumnCodeNumber))
                    {
                        tbLog.Text +=  Environment.NewLine;
                        tbLog.Text += "Kod towaru" +Environment.NewLine;
                        tbLog.Text += itemList[Settings.Default.SaleSettingsColumnCodeNumber];
                        tbLog.Text += Environment.NewLine;
                        tbLog.Text += "Cena" + Environment.NewLine;
                        tbLog.Text += itemList[Settings.Default.SaleSettingsColumnPriceNumber].Replace("b", "");
                    }
                }
                catch (Exception)
                {
                    tbLog.Text = $"Problem z wczytaniem pliku w wierszu nr {counter}. {item}";
                }

            }
            
        }
    }
}

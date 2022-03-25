using Optima_detal__.Dto;
using Optima_detal__.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optima_detal__.Db
{
    class DbSpecialPrices
    {
        public static void AddToSpecialPriceTable(List<DtoSpecialPrice> products)
        {
            int counter = 0;
            foreach (var item in products)
            {              
                SqlConnection con = new SqlConnection(Settings.Default.SqlConnectionString);
                using (SqlCommand sqlCommand = new SqlCommand("[ELTES].[AddSpecialPriceProduct]", con))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@prodCode", item.codeItem);
                    sqlCommand.Parameters.AddWithValue("@priceNr", item.typePrice);
                    sqlCommand.Parameters.AddWithValue("@prodId", item.IdItem);
                    sqlCommand.Parameters.AddWithValue("@oldPrice", item.oldPriceBrutto);
                    sqlCommand.Parameters.AddWithValue("@salePrice", item.salePriceBrutto);
                    sqlCommand.Parameters.AddWithValue("@name", item.specialPriceName);
                    sqlCommand.Parameters.AddWithValue("@dateFrom", item.saleFrom);
                    sqlCommand.Parameters.AddWithValue("@dateTo", item.saleTo);
                    try
                    {
                        if (con.State != System.Data.ConnectionState.Open)
                            con.Open();

                        sqlCommand.ExecuteNonQuery();
                        con.Close();
                        counter++;
                        Log.Info($"{counter} Dodano do promocji {item.specialPriceName} produkt {item.codeItem} ");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"DbSpecialPrices.Add() produkt id {item.IdItem} " + ex.Message);
                    }
                }
            }            
        }
        public static bool UpdatePrice(DtoSpecialPrice product, int type)
        {
            int counter = 0;           
            SqlConnection con = new SqlConnection(Settings.Default.SqlConnectionString);
            using (SqlCommand sqlCommand = new SqlCommand("[ELTES].[UpdatePrice]", con))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@priceNr", product.typePrice);
                sqlCommand.Parameters.AddWithValue("@idProduct", product.IdItem);
                sqlCommand.Parameters.AddWithValue("@price",type == 1 ? product.salePriceBrutto : product.oldPriceBrutto);
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();

                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    counter++;
                    Log.Info($"{counter} zmieniono cene nr {product.typePrice} na produkcie {product.codeItem} z {product.oldPriceBrutto} na {product.salePriceBrutto}");
                   return true;
                }
                catch (Exception ex)
                {
                    Log.Error($"DbSpecialPrices.UpgradePriced() produkt id {product.IdItem} " + ex.Message);
                    return false;
                }
            }            
        }
        public static DataTable GetSpecialPricesByName(string name)
        {
            DataTable dtSpeciaPrices = new DataTable();
            string sqlProcedure = "[ELTES].[GetSpecialPricesByName]";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                sqlProcedure, Settings.Default.SqlConnectionString);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@spName", name);
            try
            {
                sqlDataAdapter.Fill(dtSpeciaPrices);
                return dtSpeciaPrices;
            }
            catch (Exception ex)
            {
                Log.Error("DbOrder.Get().Procedura: " + sqlProcedure + ": Nie udało się pobrać zamówień z bazy. Szczegóły: " + ex.Message);
                return dtSpeciaPrices;
            }
        }
        public static void DeleteSpecialPricesFromTable(string name, int prodId, int priceNr)
        {
            SqlConnection con = new SqlConnection(Settings.Default.SqlConnectionString);
            using (SqlCommand sqlCommand = new SqlCommand("[ELTES].[DeleteSpFromTable]", con))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@priceNr", priceNr);
                sqlCommand.Parameters.AddWithValue("@prodId", prodId);
                sqlCommand.Parameters.AddWithValue("@name", name);
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Log.Error($"DbSpecialPrices.DeleteSpecialPricesFromTable() produkt id {prodId} " + ex.Message);                   
                }
            }
        }
    }
}

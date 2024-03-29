﻿using Optima_detal__.Db;
using Optima_detal__.Dto;
using Optima_detal__.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optima_detal__.Optima
{
    class OptSpecialPrices
    {
        public static string CreateSpecialPricesFromTo(List<SpecialPriceModel> specialPrice, string spName, DateTime spFrom, DateTime spTo, int priceNr, TextBox tblog)
        {
            List<SpecialPriceModel> products = new List<SpecialPriceModel>();           
            SpecialPriceModel product = null;
            foreach (var item in specialPrice)
            {
                var optProduct = DbProducts.GetByCode(item.codeItem, priceNr);
                if (optProduct.Rows.Count == 0) continue;
                foreach (DataRow row in optProduct.Rows)
                {
                    product = new SpecialPriceModel();
                    product.specialPriceName = spName;        
                    product.IdItem = row[0].ToString();
                    product.codeItem = row[1].ToString();
                    product.oldPriceBrutto = row[3].ToString();
                    product.saleFrom = spFrom;
                    product.saleTo = spTo;
                    product.typePrice = priceNr.ToString();
                    product.salePriceBrutto = item.salePriceBrutto;
                    products.Add(product);
                } 
            }
            var dtoProducts = GetDtoSpecialPrice(products);
            List<DtoSpecialPrice> productsUpdated = new List<DtoSpecialPrice>();
            int counter = 0;
            foreach (var item in dtoProducts)
            {
                var success = DbSpecialPrices.UpdatePrice(item, (int)UpdatePriceType.SpecialPrice);
                if (success)
                {
                    productsUpdated.Add(item);
                    counter++;
                    tblog.Text = $"Aktualizuje cene {counter} z {dtoProducts.Count()}";
                    tblog.Refresh();
                }
                    
            }
            DbSpecialPrices.AddToSpecialPriceTable(productsUpdated);
           
            return "";
        }
        public static List<DtoSpecialPrice> GetDtoSpecialPrice(List<SpecialPriceModel> products)
        {
            List<DtoSpecialPrice> dto = new List<DtoSpecialPrice>();
            DtoSpecialPrice dtoProd = null;
            try
            {
                foreach (var item in products)
                {
                    dtoProd = new DtoSpecialPrice();
                    dtoProd.codeItem = item.codeItem;
                    dtoProd.IdItem = Convert.ToInt32(item.IdItem);
                    dtoProd.oldPriceBrutto = Convert.ToDecimal(item.oldPriceBrutto);
                    dtoProd.salePriceBrutto = Convert.ToDecimal(item.salePriceBrutto.Replace('.',','));
                    dtoProd.specialPriceName = item.specialPriceName;
                    dtoProd.typePrice = Convert.ToInt32(item.typePrice);
                    dtoProd.saleFrom = item.saleFrom;
                    dtoProd.saleTo = item.saleTo;
                    dto.Add(dtoProd);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"GetDtoSpecialPrice " + ex.Message);
            }
            return dto;
        }
        public static List<DtoSpecialPrice> GetDtoSpecialPrice(DataTable products)
        {
            List<DtoSpecialPrice> dto = new List<DtoSpecialPrice>();
            DtoSpecialPrice dtoProd = null;
            try
            {
                foreach (DataRow item in products.Rows)
                {
                    dtoProd = new DtoSpecialPrice();
                    dtoProd.codeItem = item["Sp_TwrCode"].ToString();
                    dtoProd.IdItem = Convert.ToInt32(item["Sp_TwrOptId"]);
                    dtoProd.oldPriceBrutto = Convert.ToDecimal(item["Sp_OldPrice"]);
                    dtoProd.salePriceBrutto = Convert.ToDecimal(item["Sp_SpecialPrice"].ToString().Replace('.', ','));
                    dtoProd.specialPriceName = item["Sp_Name"].ToString();
                    dtoProd.typePrice = Convert.ToInt32(item["Sp_TwcPriceNumber"]);
                    dtoProd.saleFrom = Convert.ToDateTime(item["Sp_DateFrom"]);
                    dtoProd.saleTo = Convert.ToDateTime(item["Sp_DateTo"]);
                    dto.Add(dtoProd);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"GetDtoSpecialPrice " + ex.Message);
            }
            return dto;
        }
        public static bool DeleteSpecialPricesFromTo(string spName, TextBox tblog)
        {
            var specialPrices = GetDtoSpecialPrice(DbSpecialPrices.GetSpecialPricesByName(spName));           
            int counter = 1;
            foreach (var item in specialPrices)
            {
                var success = DbSpecialPrices.UpdatePrice(item, (int)UpdatePriceType.OldPrice);
                if (success)
                {                                    
                    tblog.Text = $"Aktualizuje cene {counter} z {specialPrices.Count()}";
                    tblog.Refresh();
                    DbSpecialPrices.DeleteSpecialPricesFromTable(item.specialPriceName, item.IdItem, item.typePrice);
                    counter++;
                }
            }
            return true;
        }
    }
}

using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class AllRowImportMap:ClassMap<AllRowImport>
    {
        public AllRowImportMap()
        {
              Id(x=>x.RowNum);
              Map(x => x.ProductName);
              Map(x=>x.Manufacturer);
              Map(x=>x.Category1);
              Map(x=>x.Category2);
              Map(x=>x.Category3);
              Map(x=>x.Category4);
              Map(x=>x.Description);
              Map(x=>x.SEKeywords);
              Map(x=>x.SEDescription);
              Map(x=>x.SETitle);
              Map(x=>x.XmlPackage);
              Map(x=>x.MiscText);
              //Map(x=>x.ExtensionData);
              Map(x=>x.VariantName);
              Map(x=>x.Make);
              Map(x=>x.Model);
              Map(x=>x.Year);
              Map(x=>x.SubModel);
              Map(x=>x.SKUSuffix);
              Map(x=>x.ManufacturerPartNumber);
              Map(x=>x.Description1);
              Map(x=>x.Price);
              Map(x=>x.SalePrice);
              Map(x=>x.MSRP);
              Map(x=>x.Cost);
              Map(x=>x.Weight);
              Map(x=>x.Dimensions);
              Map(x=>x.Inventory);
              Map(x=>x.Colors);
              Map(x=>x.ColorSKUModifiers);
              Map(x=>x.Sizes);
              Map(x=>x.SizeSKUModifiers);
              Map(x=>x.IsShipSeparately);
              Map(x=>x.Genre1);
              Map(x=>x.Genre2);
              Map(x=>x.Genre3);
              Map(x=>x.Genre4);
              Map(x=>x.Genre5);
        }
    }
}
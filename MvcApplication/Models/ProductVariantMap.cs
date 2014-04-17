using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductVariantMap:ClassMap<ProductVariant>
    {
        public ProductVariantMap()
        {
              Id(x=>x.VariantID);
              Map(x=>x.VariantGUID);
              Map(x=>x.IsDefault);
              Map(x=>x.Name);
              Map(x=>x.Description);
              Map(x=>x.SEKeywords);
              Map(x=>x.SEDescription);
              Map(x=>x.SEAltText);
              Map(x=>x.Colors);
              Map(x=>x.ColorSKUModifiers);
              Map(x=>x.Sizes);
              Map(x=>x.SizeSKUModifiers);
              Map(x=>x.FroogleDescription);
              Map(x=>x.ProductID);
              Map(x=>x.SKUSuffix);
              Map(x=>x.ManufacturerPartNumber);
              Map(x=>x.Price);
              Map(x=>x.SalePrice);
              Map(x=>x.Weight);
              Map(x=>x.MSRP);
              Map(x=>x.Cost);
              Map(x=>x.Points);
              Map(x=>x.Dimensions);
              Map(x=>x.Inventory);
              Map(x=>x.DisplayOrder);
              Map(x=>x.Notes);
              Map(x=>x.IsTaxable);
              Map(x=>x.IsShipSeparately);
              Map(x=>x.IsDownload);
              Map(x=>x.DownloadLocation);
              Map(x=>x.FreeShipping);
              Map(x=>x.Published);
              Map(x=>x.Wholesale);
              Map(x=>x.IsSecureAttachment);
              Map(x=>x.IsRecurring);
              Map(x=>x.RecurringInterval);
              Map(x=>x.RecurringIntervalType);
              Map(x=>x.SubscriptionInterval);
              Map(x=>x.RewardPoints);
              Map(x=>x.SEName);
              Map(x=>x.RestrictedQuantities);
              Map(x=>x.MinimumQuantity);
              Map(x=>x.ExtensionData);
              Map(x=>x.ExtensionData2);
              Map(x=>x.ExtensionData3);
              Map(x=>x.ExtensionData4);
              Map(x=>x.ExtensionData5);
              Map(x=>x.ContentsBGColor);
              Map(x=>x.PageBGColor);
              Map(x=>x.GraphicsColor);
              Map(x=>x.ImageFilenameOverride);
              Map(x=>x.IsImport);
              Map(x=>x.Deleted);
              Map(x=>x.CreatedOn);
              Map(x=>x.SubscriptionIntervalType);
              Map(x=>x.CustomerEntersPrice);
              Map(x=>x.CustomerEntersPricePrompt);
              Map(x=>x.Condition);
              Map(x=>x.MMYSubmodel);
        }
    }
}
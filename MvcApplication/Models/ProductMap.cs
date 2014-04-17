using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
          Id(x=>x.ProductID);
          Map(x=>x.ProductGUID);
          Map(x=>x.Name);
          Map(x=>x.Summary);
          Map(x=>x.Description);
          Map(x=>x.SEKeywords);
          Map(x=>x.SEDescription);
          Map(x=>x.SpecTitle);
          Map(x=>x.MiscText);
          Map(x=>x.SwatchImageMap);
          Map(x=>x.IsFeaturedTeaser);
          Map(x=>x.FroogleDescription);
          Map(x=>x.SETitle);
          Map(x=>x.SENoScript);
          Map(x=>x.SEAltText);
          Map(x=>x.SizeOptionPrompt);
          Map(x=>x.ColorOptionPrompt);
          Map(x=>x.TextOptionPrompt);
          Map(x=>x.ProductTypeID);
          Map(x=>x.TaxClassID);
          Map(x=>x.SKU);
          Map(x=>x.ManufacturerPartNumber);
          Map(x=>x.SalesPromptID);
          Map(x=>x.SpecCall);
          Map(x=>x.SpecsInline);
          Map(x=>x.IsFeatured);
          Map(x=>x.XmlPackage);
          Map(x=>x.ColWidth);
          Map(x=>x.Published);
          Map(x=>x.Wholesale);
          Map(x=>x.RequiresRegistration);
          Map(x=>x.Looks);
          Map(x=>x.Notes);
          Map(x=>x.QuantityDiscountID);
          Map(x=>x.RelatedProducts);
          Map(x=>x.UpsellProducts);
          Map(x=>x.UpsellProductDiscountPercentage);
          Map(x=>x.RelatedDocuments);
          Map(x=>x.TrackInventoryBySizeAndColor);
          Map(x=>x.TrackInventoryBySize);
          Map(x=>x.TrackInventoryByColor);
          Map(x=>x.IsAKit);
          Map(x=>x.ShowInProductBrowser);
          Map(x=>x.IsAPack);
          Map(x=>x.PackSize);
          Map(x=>x.ShowBuyButton);
          Map(x=>x.RequiresProducts);
          Map(x=>x.HidePriceUntilCart);
          Map(x=>x.IsCalltoOrder);
          Map(x=>x.ExcludeFromPriceFeeds);
          Map(x=>x.RequiresTextOption);
          Map(x=>x.TextOptionMaxLength);
          Map(x=>x.SEName);
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
          Map(x=>x.IsSystem);
          Map(x=>x.Deleted);
          Map(x=>x.CreatedOn);
          Map(x=>x.PageSize);
          Map(x=>x.WarehouseLocation);
          Map(x=>x.AvailableStartDate);
          Map(x=>x.AvailableStopDate);
          Map(x=>x.GoogleCheckoutAllowed);
          Map(x=>x.SkinID);
          Map(x=>x.TemplateName);
        }
    }
}
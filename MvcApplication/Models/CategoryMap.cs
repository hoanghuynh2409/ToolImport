using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class CategoryMap: ClassMap<Category>
    {
        public CategoryMap()
        {
              Id(x=>x.CategoryID);
              Map(x=>x.CategoryGUID);
              Map(x=>x.Name);
              Map(x=>x.Summary);
              Map(x=>x.Description);
              Map(x=>x.SEKeywords);
              Map(x=>x.SEDescription);
              Map(x=>x.DisplayPrefix);
              Map(x=>x.SETitle);
              Map(x=>x.SENoScript);
              Map(x=>x.SEAltText);
              Map(x=>x.ParentCategoryID);
              Map(x=>x.ColWidth);
              Map(x=>x.SortByLooks);
              Map(x=>x.DisplayOrder);
              Map(x=>x.RelatedDocuments);
              Map(x=>x.XmlPackage);
              Map(x=>x.Published);
              Map(x=>x.Wholesale);
              Map(x=>x.AllowSectionFiltering);
              Map(x=>x.AllowManufacturerFiltering);
              Map(x=>x.AllowProductTypeFiltering);
              Map(x=>x.QuantityDiscountID);
              Map(x=>x.ShowInProductBrowser);
              Map(x=>x.SEName);
              Map(x=>x.ExtensionData);
              Map(x=>x.ContentsBGColor);
              Map(x=>x.PageBGColor);
              Map(x=>x.GraphicsColor);
              Map(x=>x.ImageFilenameOverride);
              Map(x=>x.IsImport);
              Map(x=>x.Deleted);
              Map(x=>x.CreatedOn);
              Map(x=>x.PageSize);
              Map(x=>x.TaxClassID);
              Map(x=>x.SkinID);
              Map(x=>x.TemplateName);
        }
    }
}
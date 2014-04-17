using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ManufacturerMap: ClassMap<Manufacturer>
    {
        public ManufacturerMap()
        {
            Id(x => x.ManufacturerID);
            Map(x => x.ManufacturerGUID);
            Map(x => x.Name);
            Map(x => x.SEName);
            Map(x => x.SEKeywords);
            Map(x => x.SEDescription);
            Map(x => x.SETitle);
            Map(x => x.SENoScript);
            Map(x => x.SEAltText);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.Suite);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.ZipCode);
            Map(x => x.Country);
            Map(x => x.Phone);
            Map(x => x.FAX);
            Map(x => x.URL);
            Map(x => x.Email);
            Map(x => x.QuantityDiscountID);
            Map(x => x.SortByLooks);
            Map(x => x.Summary);
            Map(x => x.Description);
            Map(x => x.Notes);
            Map(x => x.RelatedDocuments);
            Map(x => x.XmlPackage);
            Map(x => x.ColWidth);
            Map(x => x.DisplayOrder);
            Map(x => x.ExtensionData);
            Map(x => x.ContentsBGColor);
            Map(x => x.PageBGColor);
            Map(x => x.GraphicsColor);
            Map(x => x.ImageFilenameOverride);
            Map(x => x.Published);
            Map(x => x.Wholesale);
            Map(x => x.ParentManufacturerID);
            Map(x => x.IsImport);
            Map(x => x.Deleted);
            Map(x => x.CreatedOn);
            Map(x => x.PageSize);
            Map(x => x.SkinID);
            Map(x => x.TemplateName);
        }
    }
}
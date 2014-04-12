using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Category
    {
      public virtual int? CategoryID {get;set;}
      public virtual Guid CategoryGUID {get;set;}
      public virtual string Name {get;set;}
      public virtual string Summary {get;set;}
      public virtual string Description {get;set;}
      public virtual string SEKeywords {get;set;}
      public virtual string SEDescription {get;set;}
      public virtual string DisplayPrefix {get;set;}
      public virtual string SETitle {get;set;}
      public virtual string SENoScript {get;set;}
      public virtual string SEAltText {get;set;}
      public virtual int ParentCategoryID {get;set;}
      public virtual int ColWidth {get;set;}
      public virtual int SortByLooks {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual string RelatedDocuments {get;set;}
      public virtual string XmlPackage {get;set;}
      public virtual int Published {get;set;}
      public virtual int Wholesale {get;set;}
      public virtual int AllowSectionFiltering {get;set;}
      public virtual int AllowManufacturerFiltering {get;set;}
      public virtual int AllowProductTypeFiltering {get;set;}
      public virtual int QuantityDiscountID {get;set;}
      public virtual int ShowInProductBrowser {get;set;}
      public virtual string SEName {get;set;}
      public virtual string ExtensionData {get;set;}
      public virtual string ContentsBGColor {get;set;}
      public virtual string PageBGColor {get;set;}
      public virtual string GraphicsColor {get;set;}
      public virtual string ImageFilenameOverride {get;set;}
      public virtual int IsImport {get;set;}
      public virtual int Deleted {get;set;}
      public virtual DateTime CreatedOn {get;set;}
      public virtual int PageSize {get;set;}
      public virtual int TaxClassID {get;set;}
      public virtual int SkinID {get;set;}
      public virtual string TemplateName {get;set;}
    }
}
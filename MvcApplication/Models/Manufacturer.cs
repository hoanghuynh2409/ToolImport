﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Manufacturer
    {
      public virtual int ManufacturerID {get;set;}
      public virtual Guid ManufacturerGUID {get;set;}
      public virtual string Name {get;set;}
      public virtual string SEName {get;set;}
      public virtual string SEKeywords {get;set;}
      public virtual string SEDescription {get;set;}
      public virtual string SETitle {get;set;}
      public virtual string SENoScript {get;set;}
      public virtual string SEAltText {get;set;}
      public virtual string Address1 {get;set;}
      public virtual string Address2 {get;set;}
      public virtual string Suite {get;set;}
      public virtual string City {get;set;}
      public virtual string State {get;set;}
      public virtual string ZipCode {get;set;}
      public virtual string Country {get;set;}
      public virtual string Phone {get;set;}
      public virtual string FAX {get;set;}
      public virtual string URL {get;set;}
      public virtual string Email {get;set;}
      public virtual string QuantityDiscountID {get;set;}
      public virtual int SortByLooks {get;set;}
      public virtual string Summary {get;set;}
      public virtual string Description {get;set;}
      public virtual string Notes {get;set;}
      public virtual string RelatedDocuments {get;set;}
      public virtual string XmlPackage {get;set;}
      public virtual int ColWidth {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual string ExtensionData {get;set;}
      public virtual string ContentsBGColor {get;set;}
      public virtual string PageBGColor {get;set;}
      public virtual string GraphicsColor {get;set;}
      public virtual string ImageFilenameOverride {get;set;}
      public virtual int Published {get;set;}
      public virtual int Wholesale {get;set;}
      public virtual int ParentManufacturerID {get;set;}
      public virtual int IsImport {get;set;}
      public virtual int Deleted {get;set;}
      public virtual string CreatedOn {get;set;}
      public virtual int PageSize {get;set;}
      public virtual int SkinID {get;set;}
      public virtual string TemplateName {get;set;}
    }
}
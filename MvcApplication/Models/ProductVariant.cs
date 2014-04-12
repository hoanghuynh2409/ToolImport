using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductVariant
    {
      public virtual int? VariantID {get;set;}
      public virtual Guid VariantGUID {get;set;}
      public virtual int IsDefault {get;set;}
      public virtual string Name {get;set;}
      public virtual string Description {get;set;}
      public virtual string SEKeywords {get;set;}
      public virtual string SEDescription {get;set;}
      public virtual string SEAltText {get;set;}
      public virtual string Colors {get;set;}
      public virtual string ColorSKUModifiers {get;set;}
      public virtual string Sizes {get;set;}
      public virtual string SizeSKUModifiers {get;set;}
      public virtual string FroogleDescription {get;set;}
      public virtual int ProductID {get;set;}
      public virtual string SKUSuffix {get;set;}
      public virtual string ManufacturerPartNumber {get;set;}
      public virtual float Price {get;set;}
      public virtual float SalePrice { get; set; }
      public virtual float Weight { get; set; }
      public virtual float MSRP { get; set; }
      public virtual float Cost { get; set; }
      public virtual int Points {get;set;}
      public virtual string Dimensions {get;set;}
      public virtual int Inventory {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual string Notes {get;set;}
      public virtual int IsTaxable {get;set;}
      public virtual int IsShipSeparately {get;set;}
      public virtual int IsDownload {get;set;}
      public virtual string DownloadLocation {get;set;}
      public virtual int FreeShipping {get;set;}
      public virtual int Published {get;set;}
      public virtual int Wholesale {get;set;}
      public virtual int IsSecureAttachment {get;set;}
      public virtual int IsRecurring { get; set; }
      public virtual int RecurringInterval { get; set; }
      public virtual int RecurringIntervalType { get; set; }
      public virtual int SubscriptionInterval { get; set; }
      public virtual int RewardPoints { get; set; }
      public virtual string SEName {get;set;}
      public virtual string RestrictedQuantities {get;set;}
      public virtual int MinimumQuantity { get; set; }
      public virtual string ExtensionData {get;set;}
      public virtual string ExtensionData2 {get;set;}
      public virtual string ExtensionData3 {get;set;}
      public virtual string ExtensionData4 {get;set;}
      public virtual string ExtensionData5 {get;set;}
      public virtual string ContentsBGColor {get;set;}
      public virtual string PageBGColor {get;set;}
      public virtual string GraphicsColor {get;set;}
      public virtual string ImageFilenameOverride {get;set;}
      public virtual int IsImport { get; set; }
      public virtual int Deleted { get; set; }
      public virtual DateTime CreatedOn {get;set;}
      public virtual int SubscriptionIntervalType { get; set; }
      public virtual int CustomerEntersPrice { get; set; }
      public virtual string CustomerEntersPricePrompt {get;set;}
      public virtual int Condition { get; set; }
      public virtual string MMYSubmodel {get;set;}
    }
}
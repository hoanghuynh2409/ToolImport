using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Product
    {
          public virtual int ProductID {get;set;}
          public virtual Guid ProductGUID {get;set;}
          public virtual string Name {get;set;}
          public virtual string Summary {get;set;}
          public virtual string Description {get;set;}
          public virtual string SEKeywords {get;set;}
          public virtual string SEDescription {get;set;}
          public virtual string SpecTitle {get;set;}
          public virtual string MiscText {get;set;}
          public virtual string SwatchImageMap {get;set;}
          public virtual string IsFeaturedTeaser {get;set;}
          public virtual string FroogleDescription {get;set;}
          public virtual string SETitle {get;set;}
          public virtual string SENoScript {get;set;}
          public virtual string SEAltText {get;set;}
          public virtual string SizeOptionPrompt {get;set;}
          public virtual string ColorOptionPrompt {get;set;}
          public virtual string TextOptionPrompt {get;set;}
          public virtual int ProductTypeID {get;set;}
          public virtual int TaxClassID {get;set;}
          public virtual string SKU {get;set;}
          public virtual string ManufacturerPartNumber {get;set;}
          public virtual int SalesPromptID {get;set;}
          public virtual string SpecCall {get;set;}
          public virtual int SpecsInline {get;set;}
          public virtual int IsFeatured {get;set;}
          public virtual string XmlPackage {get;set;}
          public virtual int ColWidth {get;set;}
          public virtual int Published {get;set;}
          public virtual int Wholesale {get;set;}
          public virtual int RequiresRegistration {get;set;}
          public virtual int Looks {get;set;}
          public virtual string Notes {get;set;}
          public virtual int QuantityDiscountID {get;set;}
          public virtual string RelatedProducts {get;set;}
          public virtual string UpsellProducts {get;set;}
          public virtual float UpsellProductDiscountPercentage {get;set;}
          public virtual string RelatedDocuments {get;set;}
          public virtual int TrackInventoryBySizeAndColor {get;set;}
          public virtual int TrackInventoryBySize {get;set;}
          public virtual int TrackInventoryByColor {get;set;}
          public virtual int IsAKit {get;set;}
          public virtual int ShowInProductBrowser {get;set;}
          public virtual int IsAPack { get; set; }
          public virtual int PackSize { get; set; }
          public virtual int ShowBuyButton { get; set; }
          public virtual string RequiresProducts {get;set;}
          public virtual int HidePriceUntilCart { get; set; }
          public virtual int IsCalltoOrder { get; set; }
          public virtual int ExcludeFromPriceFeeds {get;set;}
          public virtual int RequiresTextOption { get; set; }
          public virtual int TextOptionMaxLength { get; set; }
          public virtual string SEName {get;set;}
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
          public virtual int IsSystem { get; set; }
          public virtual int Deleted { get; set; }
          public virtual string CreatedOn {get;set;}
          public virtual int PageSize { get; set; }
          public virtual string WarehouseLocation {get;set;}
          public virtual string AvailableStartDate {get;set;}
          public virtual string AvailableStopDate { get; set; }
          public virtual int GoogleCheckoutAllowed {get;set;}
          public virtual int SkinID {get;set;}
          public virtual string TemplateName {get;set;}
    }
}
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class DB
    {
        private static ISessionFactory sessfac = NHibertnateSession.CreateSessionFactory();
        //load list from table AllRowImport
        public static IEnumerable<AllRowImport> listAllRowImport()
        {
            using (var session = sessfac.OpenSession())
            {
                var q = session.CreateCriteria<AllRowImport>().List<AllRowImport>().Take(20);
                return q;
            }
        }
        //get a record from table AllRowImport
        public static AllRowImport getAItemFromAllRowImport(int id)
        {
            using (var session = sessfac.OpenSession())
            {
               // var q = session.CreateCriteria<AllRowImport>().List<AllRowImport>().Take(20);
                var q = session.Load<AllRowImport>(id);
                return q;
            }
        }
        public static void updateStatusAllRowImport(int rownum,int status)
        {
            using (var session = sessfac.OpenSession())
            {
                using (var Transaction = session.BeginTransaction())
                {
                    var demo = session.Load<AllRowImport>(rownum);
                    demo.status = status;
                    session.SaveOrUpdate(demo);
                    Transaction.Commit();
                }

            }
        }
        //Update 
        public static void updateAItemOfAllRowImport(int id,AllRowImport ari)
        {
            using (var session = sessfac.OpenSession())
            {
                using (var Transaction = session.BeginTransaction())
                {
                    var demo = session.Load<AllRowImport>(id);
                    demo.ProductName = ari.ProductName;
                    demo.Manufacturer = ari.Manufacturer;
                    demo.Category1 = ari.Category1;
                    demo.VariantName = ari.VariantName;
                    demo.Make = ari.Make;
                    demo.Model = ari.Model;
                    demo.Year = ari.Year;
                    demo.Price = ari.Price;
                    demo.SKUSuffix = ari.SKUSuffix;
                    session.SaveOrUpdate(demo);
                    Transaction.Commit();
                }

            }
        }
        //Delete 
        public static void deleteAItemOfAllRowImport(int id)
        {
            using (var session = sessfac.OpenSession())
            {
                using (var Transaction = session.BeginTransaction())
                {
                    var demo = session.Load<AllRowImport>(id);
                    session.Delete(demo);
                    Transaction.Commit();
                }
            }
        }

        // method check exist product, if exist return productID else 0
        public static int checkExistProduct(string productName, string manufacturerName)
        {
            using (ISession session = sessfac.OpenSession())
            {
                Manufacturer m = null;
                Product p = null;
                ProductManufacturer pm = null;
                var result = session.QueryOver<ProductManufacturer>(() => pm)
                    .JoinAlias(() => pm.ProductFor, () => p)
                    .JoinAlias(() => pm.ManufacturerFor, () => m)
                    .Where(() => p.Deleted == 0 && p.Name == productName && m.Name == manufacturerName)
                    .Select(c => p.ProductID).List<int>();
                return (result.Count() > 0 ? result[0] : 0);
            }
        }
        //insert new product
        public static int insertNewProduct(string Name, String Description, string XmlPackage, string MiscText, string ManufacturerPartNumber)
        {
            int productID = 0;
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    Product p = new Product();
                    p.ProductGUID = Guid.NewGuid();
                    p.Name = Name;
                    p.Description = Description;
                    p.Published = 1;
                    p.Deleted = 0;
                    p.XmlPackage = XmlPackage;
                    p.SEName = Name.Replace(" ", "-").ToLower(); ;
                    p.MiscText = MiscText;
                    p.ExtensionData = "";
                    p.ManufacturerPartNumber = ManufacturerPartNumber;
                    p.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    p.AvailableStartDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    p.TemplateName = "";
                    session.Save(p);
                    tran.Commit();
                    productID = (Int32)p.ProductID;
                }
            }
            return productID;
        }
        // check exist manufacturer return ManufacturerID
        public static int checkExistManufacturer(string manufacturerName)
        {
            int mId = 0;
            using (var session = sessfac.OpenSession())
            {
                var mlist = session.QueryOver<Manufacturer>().Where(c => c.Name == manufacturerName).List();
                if (mlist.Count() > 0)
                {
                    mId = mlist.FirstOrDefault().ManufacturerID;
                }
            }
            return mId;
        }
        // Insert manufacturer
        public static int insertManufacturer(String manufacturerName)
        {
            int mId = 0;
            //  Name,SEName,SortBLooks=0,XmlPackage=entity.MMYGrid.xml.config,ColWidth=4,DisplayOrder=1,Published=1,Wholesale=0
            //ParentManufacturerID=0,IsImport=0,Deleted=0,CreatedOn,PageSize=20,SkinID=0,TemplateName=""
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    Manufacturer m = new Manufacturer();
                    m.ManufacturerGUID = Guid.NewGuid();
                    m.Name = manufacturerName;
                    m.SEName = manufacturerName.ToLower();
                    m.SortByLooks = 0;
                    m.XmlPackage = "entity.MMYGrid.xml.config";
                    m.ColWidth = 4;
                    m.DisplayOrder = 1;
                    m.Published = 1;
                    m.Wholesale = 0;
                    m.ParentManufacturerID = 0;
                    m.IsImport = 0;
                    m.Deleted = 0;
                    m.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    m.PageSize = 20;
                    m.SkinID = 0;
                    m.TemplateName = "";
                    session.Save(m);
                    tran.Commit();
                    mId = (Int32)m.ManufacturerID;
                }
            }
            return mId;
        }
        // check exist productManufacturer
        public static bool checkExistProductManufurer(int productID,int manufacturerID)
        {
            using (ISession session = sessfac.OpenSession())
            {
                using (ITransaction Transaction = session.BeginTransaction())
                {
                    var pm = session.QueryOver<ProductManufacturer>().Where(c => c.ProductFor.ProductID==productID && c.ManufacturerFor.ManufacturerID==manufacturerID).List<ProductManufacturer>();
                    if (pm.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        // Insert productManufacturer
        public static void insertProductManufacturer(int productID, int manufurerID)
        {
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    var plist = session.CreateCriteria<Product>().List<Product>().Where(p => p.ProductID == productID).SingleOrDefault();
                    var mlist = session.CreateCriteria<Manufacturer>().List<Manufacturer>().Where(p => p.ManufacturerID == manufurerID).SingleOrDefault();

                    ProductManufacturer pm1 = new ProductManufacturer()
                    {
                        ProductFor = plist,
                        ManufacturerFor = mlist,
                        DisplayOrder = 1,
                        CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };
                    session.Save(pm1);
                    tran.Commit();
                }
            }
        }

        // check category
        public static int checkExistCategory(string categoryName)
        {
            int catid = 0;
            using (var session = sessfac.OpenSession())
            {
                var mlist = session.QueryOver<Category>().Where(c => c.Name == categoryName).List();
                if (mlist.Count() > 0)
                {
                    catid = (int)mlist.FirstOrDefault().CategoryID;
                }
            }
            return catid;
        }

        public static int insertCategory(String name)
        {
            //CategoryGUID,Name,QuantityDiscountID=0,XmlPackage='entity.mmygrid.xml.config',SEName='replace blank by -'
            int cateID = 0;
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    Category c = new Category();
                    c.CategoryGUID = Guid.NewGuid();
                    c.Name = name;
                    c.QuantityDiscountID = 0;
                    c.SEName = name.Replace(" ","-").ToLower();
                    c.SortByLooks = 0;
                    c.XmlPackage = "entity.mmygrid.xml.config";
                    c.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    c.TemplateName = "";
                    session.Save(c);
                    tran.Commit();
                    cateID = (Int32)c.CategoryID;
                }
            }
            return cateID;
        }
        // check exist productManufacturer
        public static bool checkExistProductCategory(int productID, int cateID)
        {
            using (ISession session = sessfac.OpenSession())
            {
                using (ITransaction Transaction = session.BeginTransaction())
                {
                    var pm = session.QueryOver<ProductCategory>().Where(c => c.Product.ProductID == productID && c.Category.CategoryID == cateID).List<ProductCategory>();
                    if (pm.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        // Insert productCategory
        public static void insertProductCategory(int productID, int cateID)
        {
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    var plist = session.CreateCriteria<Product>().List<Product>().Where(p => p.ProductID == productID).SingleOrDefault();
                    var mlist = session.CreateCriteria<Category>().List<Category>().Where(p => p.CategoryID == cateID).SingleOrDefault();

                    ProductCategory pm1 = new ProductCategory()
                    {
                        Product = plist,
                        Category = mlist,
                        DisplayOrder = 1,
                        CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };
                    session.Save(pm1);
                    tran.Commit();
                }
            }
        }

        //check exist product Variant
        public static int checkExistProductVariant(int productID,String mmySubmodel,String SKU)
        {
            int variantID = 0;
            using (var session = sessfac.OpenSession())
            {
                //Deleted=0 AND ProductID=168420 AND MMYSubmodel=N'AWD' AND SKUSuffix=N'EOE.65030'
                var pvlist = session.QueryOver<ProductVariant>().Where(c => c.Deleted == 0 && c.ProductID==productID && c.MMYSubmodel==DB.ReplaceFomat(mmySubmodel) && c.SKUSuffix==SKU).List();
                if (pvlist.Count() > 0)
                {
                    variantID = (int)pvlist.FirstOrDefault().VariantID;
                }
            }
            return variantID;
        }

        public static int countProductVariantDefualtby1(int ProductID)
        {
            int num = 0;
            using (var session = sessfac.OpenSession())
            {
                //Deleted=0 and Published=1 and ProductID=168420 and IsDefault=1
                var pvlist = session.QueryOver<ProductVariant>().Where(c => c.Deleted == 0 && c.ProductID == ProductID && c.IsDefault == 1).List();//&& c.Published == 1
                if (pvlist.Count() > 0)
                {
                    num = pvlist.Count();
                }
            }
            return num;
        }

        // insert product variant
        public static int insertProductVariant(int productId,string name,string sku,float price,string Description,float weight,float msrp,int isdefault,string mmysubmodel)
        {
            int variantID = 0;
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    ProductVariant pv = new ProductVariant();
                    pv.VariantGUID = Guid.NewGuid();
                    pv.Name = name;
                    pv.ProductID = productId;
                    pv.SKUSuffix = sku;
                    pv.Inventory = 0;
                    pv.Price = price;
                    pv.SalePrice = null;
                    pv.ManufacturerPartNumber = "";
                    pv.Description = Description;
                    pv.Weight = weight;
                    pv.MSRP = msrp;
                    pv.Cost = 0;
                    pv.Dimensions = "";
                    pv.Inventory = 0;
                    pv.MMYSubmodel =mmysubmodel;
                    pv.Colors = "";
                    pv.ColorSKUModifiers = "";
                    pv.Sizes = "";
                    pv.IsDefault = isdefault;
                    pv.SizeSKUModifiers = "";
                    pv.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    session.Save(pv);
                    tran.Commit();
                    variantID = (Int32)pv.VariantID;
                }
            }
            return variantID;
        }
        //check 
        public static int checkCompunix_makemodelyear(string make,string model, string year)
        {
            int mmy = 0;
            using (var session = sessfac.OpenSession())
            {
                //make = N'Ford' and model = N'Aerostar' and year = N'1990'
                var pvlist = session.QueryOver<Compunix_MakeModelYear>().Where(c => c.Make == make && c.Model == model && c.Year == year).List();
                if (pvlist.Count() > 0)
                {
                    mmy = pvlist.FirstOrDefault().MMYID;
                }
            }
            return mmy;
        }

        //insert compunix_MMY
        public static int insertCompunix_makemodelyear(string make, string model, string year)
        {
            int mmy = 0;
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    Compunix_MakeModelYear cmmy = new Compunix_MakeModelYear();
                    cmmy.Make = make;
                    cmmy.Model = model;
                    cmmy.Year = year;
                    session.Save(cmmy);
                    tran.Commit();
                    mmy= (Int32)cmmy.MMYID;
                }
            }
            return mmy;
        }
        //mmyid = @MMYID and productid = @PID and variantid = @VID
        public static int checkCompunix_ProductMMY(int mmyid, int productid, int variantid)
        {
            int mmy = 0;
            using (var session = sessfac.OpenSession())
            {
                //make = N'Ford' and model = N'Aerostar' and year = N'1990'
                var pvlist = session.QueryOver<Compunix_ProductMMY>().Where(c => c.MMYID == mmyid && c.ProductID == productid && c.VariantID == variantid).List();
                if (pvlist.Count() > 0)
                {
                    mmy = pvlist.FirstOrDefault().PMMYID;
                }
            }
            return mmy;
        }

        //insert compunix_ProductMMY
        public static int insertCompunix_ProductMMY(int mmyid, int productid, int variantid)
        {
            int mmy = 0;
            using (var session = sessfac.OpenSession())
            {
                using (var tran = session.BeginTransaction())
                {
                    Compunix_ProductMMY cmmy = new Compunix_ProductMMY();
                    cmmy.MMYID = mmyid;
                    cmmy.ProductID = productid;
                    cmmy.VariantID = variantid;
                    session.Save(cmmy);
                    tran.Commit();
                    mmy = (Int32)cmmy.PMMYID;
                }
            }
            return mmy;
        }

        public void ImportData()
        {
                int n = 0;
                while(n<1)
                {
                    using (var session = sessfac.OpenSession())
                    {
                        var a = session.CreateCriteria<AllRowImport>().List<AllRowImport>().Where(ar => ar.status == 0).Take(1000).ToList();
                        if (a.Count() > 0)
                        {
                            executeImport(a);
                            n = 0;
                        }
                        else
                        {
                            n = 2;
                        }
                    }
                }
        }

        public void executeImport(List<AllRowImport> rowimport)
        {
            int rownum = 0;
            foreach (var a in rowimport)
            {
                try
                {
                    rownum = a.RowNum;
                    int productID = Product(a.ProductName, a.Manufacturer, a.Description, a.XmlPackage, a.MiscText, a.ManufacturerPartNumber);
                    Category(productID, a.Category1);
                    int pviD = ProductVariant(productID, a.VariantName, a.Price, a.Description1, a.Weight, a.MSRP, a.Make, a.Model, a.Year, a.SubModel, a.SKUSuffix);
                    DB.updateStatusAllRowImport(rownum, 1);
                }
                catch (Exception e)
                {
                    DB.updateStatusAllRowImport(rownum,2);
                }
            }
        }
        // method check import data
        //product manufacturer
        public int Product(string Name,string manufacturerName ,string Description, string XmlPackage,
                                       string MiscText, string ManufacturerPartNumber)
        {
            int proID=DB.checkExistProduct(Name,manufacturerName);
            if (proID == 0)
            {
                proID = DB.insertNewProduct(Name,Description,XmlPackage,MiscText,ManufacturerPartNumber);
            }
            int mid = DB.checkExistManufacturer(manufacturerName);
            if (mid == 0)
            {
                mid = DB.insertManufacturer(manufacturerName);
            }
            if (DB.checkExistProductManufurer(proID, mid) == false)
            {
                DB.insertProductManufacturer(proID, mid);
            }
            return proID;
        }
        // category
        public void Category(int productID,string cateName)
        {
            int cateid=DB.checkExistCategory(cateName);
            if (cateid == 0)
            {
                cateid = DB.insertCategory(cateName);
            }
            if (DB.checkExistProductCategory(productID, cateid) == false)
            {
                DB.insertProductCategory(productID, cateid);
            }
        }
        // product variant
        public int ProductVariant(int productId,string name,float price,string description,float weight,float msrp,
                                 string make,string model,float year,string mmysubmodel,string sku)
        {
            int pvId = 0;
            try
            {
                //int productId,string name,string sku,float price,string Description,float weight,float msrp,string mmysubmodel
                string submodelformat=(mmysubmodel==null)?ReplaceFomat(mmysubmodel):"";
                pvId = DB.checkExistProductVariant(productId, submodelformat.Trim(), sku);
                if (pvId == 0)
                {
                    int isdefault = 0;
                    if (countProductVariantDefualtby1(productId) == 0)
                    {
                        isdefault = 1;
                    }
                    pvId = DB.insertProductVariant(productId, name, sku, price, description, weight, msrp, isdefault, submodelformat.Trim());
                }
                int mmyid = checkCompunix_makemodelyear(make, model, year.ToString());
                if (mmyid == 0)
                {
                    mmyid = DB.insertCompunix_makemodelyear(make, model, year.ToString());
                }
                int pvmmy = checkCompunix_ProductMMY(mmyid, productId, pvId);
                if (pvmmy == 0)
                {
                    DB.insertCompunix_ProductMMY(mmyid, productId, pvId);
                }
                return pvId;
            }
            catch (Exception e)
            {
                string er = e.Message;
            }
            return pvId;
        }

        public static string ReplaceFomat(String str)
        {
            return str.Replace("&", "")
                    .Replace(",", "")
                    .Replace(";", "")
                    .Replace("#", "")
                    .Replace(" /", "/")
                    .Replace("/ ", "/")
                    .Replace("- ", "-")
                    .Replace(" -", "-")
                    .Replace("  ", " ")
                    .Replace("  ", " ")
                    .Replace("  ", " ")
                    .Replace("  ", " ")
                    .Replace("-", " ");
        }
    }
}
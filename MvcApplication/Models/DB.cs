using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class DB
    {
        // method return productID
        public static int checkExistProduct(string productName, string manufacturerName)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                Manufacturer m = null;
                Product p = null;
                ProductManufacturer pm = null;
                var result = session.QueryOver<ProductManufacturer>(() => pm)
                    .JoinAlias(() => pm.ProductFor, () => p)
                    .JoinAlias(() => pm.ManufacturerFor, () => m)
                    .Where(() => p.Deleted == 0 && p.Name == productName && m.Name == manufacturerName)
                    .Select(c => pm.ProductID).List<int>();
                return (result.Count() > 0 ? result[0] : 0);
            }
        }

        public static int insertNewProduct(string Name,String Description,string XmlPackage,string SEName,string MiscText,string ExtensionData,string ManufacturerPartNumber)
        {
            int productID = 0;
            using (ISession session = NHibertnateSession.OpenSession())
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
                    p.SEName = SEName;
                    p.MiscText = MiscText;
                    p.ExtensionData = ExtensionData;
                    p.ManufacturerPartNumber = ManufacturerPartNumber;
                    p.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    p.AvailableStartDate =DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    p.TemplateName = "";
                    session.Save(p);
                    tran.Commit();
                    productID = (Int32)p.ProductID;
                }
            }
            return productID;
        }

        public static int checkExistManufacturer(string manufacturerName)
        {
            int mId = 0;
            using (ISession session = NHibertnateSession.OpenSession())
            {
                var mlist = session.QueryOver<Manufacturer>().Where(c => c.Name == manufacturerName).List();
                if (mlist.Count() > 0)
                {
                    mId = mlist.SingleOrDefault().ManufacturerID;
                }
            }
            return mId;
        }

        public static int insertManufacturer(String manufacturerName)
        {
            int mId = 0;
            //  Name,SEName,SortBLooks=0,XmlPackage=entity.MMYGrid.xml.config,ColWidth=4,DisplayOrder=1,Published=1,Wholesale=0
               //ParentManufacturerID=0,IsImport=0,Deleted=0,CreatedOn,PageSize=20,SkinID=0,TemplateName=""
            using(ISession session = NHibertnateSession.OpenSession())
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

        public static void deleteProductManufurer(int productID)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                using (ITransaction Transaction = session.BeginTransaction())
                {
                    //var pm = session.QueryOver<ProductManufacturer>().Where(c => c.ProductID == productID).List<ProductManufacturer>();
                    var pm = session.Load<ProductManufacturer>(productID);
                    session.Delete(pm);
                    Transaction.Commit();
                }

            }
        }

        public static void insertProductManufurer(int productID,int manufurerID)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())
                {
                    var plist = session.Load<Product>(productID);
                    var mlist = session.Load<Manufacturer>(manufurerID);
                    ProductManufacturer pm = new ProductManufacturer();
                    pm.ProductID = productID;
                    pm.ManufacturerID = manufurerID;
                    pm.ProductFor = plist;
                    pm.ManufacturerFor = mlist;
                    pm.DisplayOrder = 1;
                    pm.CreatedOn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    session.Save(pm);
                    tran.Commit();
                }
            }
        }
    }
}
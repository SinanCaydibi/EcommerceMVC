using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name="Telefon ürünleri", Description="Telefon ürünleri"},
                new Category() { Name="Televizyon ürünleri", Description="Televizyon ürünleri"},
                new Category() { Name="Beyaz Eşya", Description="beyaz eşya ürünleri"},
                new Category() { Name="Akıllı ev sistemleri", Description="Akıllı ev sistemleri"}

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() { Name="İphone", Description="Çok iyi", Price=1200 ,Stock=500, IsApproved=true, CategoryId=1 , IsHome=true ,Image="1.jpg"},
                new Product() { Name="İphone", Description="Çok iyi", Price=1200 ,Stock=500, IsApproved=true, CategoryId=1 , IsHome=true ,Image="2.jpg"},
                new Product() { Name="İphone", Description="Çok iyi", Price=1200 ,Stock=500, IsApproved=true, CategoryId=1 , IsHome=true ,Image="3.jpg"},
                new Product() { Name="İphone", Description="Çok iyi", Price=1200 ,Stock=500, IsApproved=true, CategoryId=1 , IsHome=true ,Image="4.jpg"},
                new Product() { Name="İphone", Description="Çok iyi", Price=1200 ,Stock=500, IsApproved=true, CategoryId=1 , IsHome=true ,Image="5.jpg"},
                new Product() { Name="Xiomi", Description="Çok iyi", Price=1400 ,Stock=500, IsApproved=true, CategoryId=3,Image="6.jpg"},
                new Product() { Name="Huwai", Description="Çok iyi", Price=1500 ,Stock=500, IsApproved=true, CategoryId=2,IsHome=true,Image="7.jpg"},
                new Product() { Name="", Description="Çok iyi", Price=1600 ,Stock=500, IsApproved=true, CategoryId=4,IsHome=true,Image="8.jpg"},
                


            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
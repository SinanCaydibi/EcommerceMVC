using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        //isim
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        //Açıklama
        public double Price  { get; set; }
        //fiyat
        public int Stock  { get; set; }
        public string Image { get; set; }
        //stok miktarı
        public bool IsHome { get; set; }
        public bool IsApproved  { get; set; }
        // Onaylı Ürün mü ? Satışta mı ?
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
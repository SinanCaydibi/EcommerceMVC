using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //isim
        public string Description { get; set; }
        //Açıklama
        public double Price { get; set; }
        //fiyat
        public int Stock { get; set; }
        public string Image { get; set; }
      
        public int CategoryId { get; set; }
    }
}
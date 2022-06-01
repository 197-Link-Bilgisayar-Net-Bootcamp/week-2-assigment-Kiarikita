using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    public interface IProducts
    {
        /*Ürünlerimizin sahip olacağı özellikleri tanımladık*/
        int Id { get; set; }
        int Stock { get; set; }
        int Size { get; set; }
        double Price { get; set; }
        int LegLenght { get; set; }
    }

    public class Pant : IProduct
    {
        /* Pantolon ürünü için pantolon classında interfacete tanımladığımız özellikleri implemente ettik*/
        public int Id { get; set; }
        public int Stock { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public int LegLenght { get; set; }
    }

    public class Orange : IProduct
    {
        /*Ancak eğer portakal ürününü eklemek istersek;
         * portakalın bacak boyu ya da bedeni gibi özellikleri olmamasına rağmen
         * bu özellikleri interface de tanımladığımız için bunları portakal sınıfı implement etmek zorunda kaldı.*/
        public int Id { get; set; }
        public int Stock { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public int LegLenght { get; set; }
    }

    
}

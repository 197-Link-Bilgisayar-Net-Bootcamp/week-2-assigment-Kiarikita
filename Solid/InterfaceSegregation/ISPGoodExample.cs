using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregation
{
    public interface IProduct
    {
        //Ürünlerimizin sahip olacağı ortak özellikleri tanımladık
        int Id { get; set; }
        int Stock { get; set; } 
        double Price { get; set; }
        
    }

    public interface ITrouser
    {
        //Pantolon ürününün sahip olacağı spesifik özellikleri tanımladık
        public int Size { get; set; }
        public int LegLenght { get; set; }
    }

    public interface IApple
    {
        //Elma ürününün sahip olacağı spesifik özellikleri tanımladık
        public string AppleType { get; set; }
    }

    public class Trouser : IProduct, ITrouser
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public int LegLenght { get; set; }
    }

    public class Apple : IProduct, IApple
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string AppleType { get; set; }
    }

    //prensibi uygulayarak her sınıf ortak ürün özelliklerini ürün interfaceinden, spesifik özelliklerini ise kendi interfacelerinden almış oldu


}

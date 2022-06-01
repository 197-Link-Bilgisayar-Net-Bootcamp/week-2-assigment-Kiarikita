using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosed
{

    /*Buradaki iyi örnekte eğer yeni bir meyve türünün eklenmesini istersek tüm metodu değiştirmemize gerek kalmadan,
     yeni bir class oluşturum bu classın interfaceten kalıtım almasını sağlamak yeterli olacak*/

    public interface Fruit
    {
        void CollectFruits(int quantity);
    }
    
    public class Apple : Fruit //Apple sınıfı Fruit interfacesinden kaltım alarak CollectFruits methodunu kullandı
    {
        public void CollectFruits(int quantity)
        {
            Console.WriteLine("Toplanan elma sayısı: " + quantity);
        }
    }

    public class Pear : Fruit
    {
        public void CollectFruits(int quantity)
        {
            Console.WriteLine("Toplanan armut sayısı: " + quantity);
        }
    }

    public class Orange : Fruit
    {
        public void CollectFruits(int quantity)
        {
            Console.WriteLine("Toplanan portakal sayısı: " + quantity);
        }
    }
}

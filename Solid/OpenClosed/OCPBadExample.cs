using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosed
{
    public class OCPBadExample
    {
        public void CollectFruits(string fruit, int quantity)
        {
            //Toplanan meyve miktarını gösteren bir uygulama olsun
            if (fruit == "Apple")
            {
                //Eğer meyve Apple ise bize miktarı versin
                Console.WriteLine("Toplanan elma sayısı: " + quantity);
            }

            if (fruit == "Pear")
            {
                //Eğer meyve Pear ise bize miktarı versin
                Console.WriteLine("Toplanan armut sayısı: " + quantity);
            }

            if (fruit == "Orange")
            {
                //Eğer meyve Orange ise bize miktarı versin
                Console.WriteLine("Toplanan portakal sayısı: " + quantity);
            }

            /*Bu kötü örnekte eğer kullanıcı başka bir meyve eklemek isterse yani 
             * işlevselliğini geliştirmek istersek kaynağı değiştirmek zorunda kalacağız*/
        }
    }
}

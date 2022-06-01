using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovSubstitution
{
    //derste yaptığımız örnek
    //classlar yer değiştirince program kırılmamalı
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class Phone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı.");
        }
    }

    public class IPhone : Phone, ITakePhoto //class istediği kadar interface implement edebilir
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi.");
        }
    }

    public class Nokia : Phone
    {
        
    }
}

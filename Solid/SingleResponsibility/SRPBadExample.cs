using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    public class BadInformationService
    {
        public void SendInfo(string firstName, string lastName, string email)
        {
            //SendInfo da birden fazla işlem yapılan, yanlış bir örnek

            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                /*IsNullOrWhiteSpace string türündeki değişkenin null, boş ve boşluk kontrolünü sağlar.
                 * Eğer firstName ya da lastName null/boş/boşluk karakteri varsa bize exceptionu verecek.*/

                throw new Exception("Geçersiz kullanıcı adı.");
            }
            
            if (!email.Contains("@") || !email.Contains("."))
            {
                /*Benzer şekilde eğer email içerisinde '@' ve '.' barındırmıyorsa bizi geçersiz mail adresi diyerek uyaracak. */
                throw new Exception("Geçersiz mail adresi.");
            }

            /*Bunun iyi örneğinde username ve email kontrolünü kendi içlerinde ayrı ayrı yapacağız,
             * böylece sınıfın yapması gereken yalnızca bir işi olmasını sağlayacağız.*/
        }
    }
}

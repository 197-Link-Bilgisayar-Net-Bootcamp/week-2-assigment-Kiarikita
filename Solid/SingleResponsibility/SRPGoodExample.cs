using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    public class GoodInformationService
    {
        //Single Responsibility Prensibine uyguğumuz için burada işlemlerimizi tamamlayabiliriz
        UsernameService _usernameService;
        EmailService _emailService;

        public void SendInvite(string email, string firstName, string lastName)
        {
            _usernameService.Validate(firstName, lastName);
            _emailService.Validate(email);
        }
    }
    /* Classı  böldük ve her classın yapması/işlemesi gereken tek görevi oldu*/
    public class UsernameService
    {
        public void Validate(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                /*IsNullOrWhiteSpace string türündeki değişkenin null, boş ve boşluk kontrolünü sağlar.
                 * Eğer firstName ya da lastName null/boş/boşluk karakteri varsa bize exceptionu verecek.*/
                throw new Exception("Geçersiz kullanıcı adı.");
            }
        }
    }

    public class EmailService
    {
        public void Validate(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                /*Benzer şekilde eğer email içerisinde '@' ve '.' barındırmıyorsa bizi geçersiz mail adresi diyerek uyaracak. */
                throw new Exception("Geçersiz mail adresi.");
            }
        }
    }
}

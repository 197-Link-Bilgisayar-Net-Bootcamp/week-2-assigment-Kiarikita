using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFinder.Entities
{
    //Product tablosunda hangi sütünların olacağını tanımlıyoruz
    public class Product
    {
        //primary key, identity olarak 1 den başlayarak ilerleyecek
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; } 
    }
}

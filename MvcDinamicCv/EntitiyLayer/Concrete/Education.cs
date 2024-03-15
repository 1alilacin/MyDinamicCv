using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Education
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz.")]
        public string Title { get; set; }
        public string Subtitle1 { get; set; }
        public string Subtitle2 { get; set; }

        [StringLength(10, ErrorMessage = "Lütfen en fazla 10 karakterlik veri girişi yapınız.")]
        public string GNO { get; set; }
        public string Date { get; set; }
    }
}

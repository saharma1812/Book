using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Display(Name = "گروه کتاب ")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public int GroupID { get; set; }

        [Display(Name = "عنوان ")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public string Author { get; set; }

        [Display(Name = "ناشر")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public string Publisher { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public string ShortDescription { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "تاریخ انتشار")]
        public DateTime CreateDate { get; set; }

        //Navigation property
         
        public virtual BookGroup BookGroup { get; set; }
        public virtual List<BookComment> BookComments { get; set; }

        public Book()
        {

        }

    }
}

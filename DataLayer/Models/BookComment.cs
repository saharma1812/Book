using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookComment
    {
        [Key]
        public int CommentID { get; set; }
        [Display(Name = "کتاب")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public int BookID { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]

        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        public string Email { get; set; }
        [Display(Name = "سایت")]
        
        public string WebSite { get; set; }
        [Display(Name = "نظر")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string Comment { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public DateTime CreateDate { get; set; }

        //Navigation property
        
        public virtual Book Book { get; set; }

        public BookComment()
        {

        }

    }

}

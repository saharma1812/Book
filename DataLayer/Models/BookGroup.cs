﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookGroup
    {
        [Key]
        public int GroupID { get; set; }
        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "  لطفا {0} را وارد کنید ")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        //Navigation property
        public virtual List<Book> Books { get; set; }
        public BookGroup()
        {

        }
    }
}

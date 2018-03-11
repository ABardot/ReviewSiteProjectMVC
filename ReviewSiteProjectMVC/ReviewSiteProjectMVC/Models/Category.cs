using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteProjectMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
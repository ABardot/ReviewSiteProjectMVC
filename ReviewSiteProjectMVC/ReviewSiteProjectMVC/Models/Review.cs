using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSiteProjectMVC.Models
{
    public class Review
    {
        [Key]
        public int GameID { get; set; }

        [Display(Name = "Game Title")]
        public string Title { get; set; }

        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [Display(Name = "Date Released")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PublishedDate { get; set; }

        [Display(Name = "Game Review")]
        public string GameReview { get; set; }

        [Display(Name = "Game Rating")]
        public int GameScore { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
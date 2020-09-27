using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        [Display(Name ="Post Title")]
        [Required(ErrorMessage = "Kindly enter title of your post.")]        
        public string Title { get; set; }
        public DateTime Posted { get; set; }
        public string Author { get; set; }
        [Required]
        public string Body { get; set; }
    }
}

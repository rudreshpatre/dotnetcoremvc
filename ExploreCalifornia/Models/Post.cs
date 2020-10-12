﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

        public string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }
        [Display(Name ="Post Title")]
        [Required(ErrorMessage = "Kindly enter title of your post.")]        
        public string Title { get; set; }
        public DateTime Posted { get; set; }
        public string Author { get; set; }
        [Required]
        public string Body { get; set; }
    }
}

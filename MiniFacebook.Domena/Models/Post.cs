﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFacebook.Domena.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Caption { get; set; }

        [Required]
        [StringLength(450)]
        public string Text { get; set; }
        public DateTime PostTime { get; set; }
    }
}

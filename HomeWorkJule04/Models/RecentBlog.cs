using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWorkJule04.Models
{
    public class RecentBlog
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Heading { get; set; }
        [Required, StringLength(200)]
        public string Content { get; set; }

    }
    public class RecentBlogContent
    {
        [Required, StringLength(200)]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string img { get; set; }
        [Required, StringLength(200)]
        public DateTime Date { get; set; }
        [Required, StringLength(200)]
        public string Question { get; set; }
    }
}

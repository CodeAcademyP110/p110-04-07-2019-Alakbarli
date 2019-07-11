using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWorkJule04.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string BgImage { get; set; }
        public string Heading { get; set; }
        public string HeadingDetail { get; set; }
        

    }
}

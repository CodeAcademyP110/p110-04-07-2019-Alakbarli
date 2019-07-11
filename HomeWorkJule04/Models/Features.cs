using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeWorkJule04.Models
{
    public class Features
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Icon { get; set; }
        [Required, StringLength(200)]
        
        public string Heading { get; set; }
        [Required, StringLength(200)]
        public string Content { get; set; }
    }
}

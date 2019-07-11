using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkJule04.Models;
using HomeWorkJule04.DAL;

namespace HomeWorkJule04.VModel
{
    public class IndexVm
    {
        public IEnumerable<Slide> VmSlides { get; set; }
        public IEnumerable<PopularDes> VmpopularDes { get; set; }
        public IEnumerable<HappyCostumer> VmHappyCostumers { get; set; }
        public IEnumerable<AboutMe> VmAbout { get; set; }
        public IEnumerable<Features> VmFeatures { get; set; }
        public IEnumerable<RecentBlog> VmRecentBlog { get; set; }
        public IEnumerable<RecentBlogContent> VmRecentBlogContents { get; set; }
    }
}

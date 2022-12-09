using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hello
    {
        [Key]
        public int HelloID { get; set; }
        public string Image { get; set; }
        public string Lead { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string GithubUrl { get; set; }
        public string FooterName { get; set; }
    }
}

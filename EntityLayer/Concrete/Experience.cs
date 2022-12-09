using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}

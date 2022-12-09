using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skills
    {
        [Key]
        public int SkillsID { get; set; }
        public string SkillsName { get; set; }
        public string Progress { get; set; }
    }
}

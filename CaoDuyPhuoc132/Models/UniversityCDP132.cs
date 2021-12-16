using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaoDuyPhuoc132.Models
{
    public class UniversityCDP132
    {
        [Key]
        [DisplayName("Mã trường đại học")]
        public int UniversityId { get; set; }
        [DisplayName("Tên trường đại học")]
        public string UniversityName { get; set; }
    }
}

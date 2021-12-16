using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaoDuyPhuoc132.Models
{
    public class CDP0132
    {
        [Key]
        [DisplayName("Mã sinh viên")]
        [StringLength(20)]
        public string CDPId { get; set; }
        [DisplayName("Tên sinh viên")]
        [StringLength(50)]
        public string CDPName { get; set; }
        [DisplayName("Giới tính sinh viên")]
        public bool CDPGender { get; set; }
    }
}

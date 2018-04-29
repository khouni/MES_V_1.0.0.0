using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using MES.DATA.MODEL.Entity;


namespace MES.DATA.MODEL
{
    public class Machine : AuditableEntity<long>
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string Designation { get; set; }
        [MaxLength(50)]
        public string Reference { get; set; }
        public int Year { get; set; }
        public int Tons { get; set; }
        public int Index { get; set; }
        public int Numbre { get; set; }
    }

}

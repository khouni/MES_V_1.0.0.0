using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MES.DATA.MODEL
{
    public class Machine
    {
        [Key]
        [MaxLength(32)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string Designation { get; set; }
        public string Reference { get; set; }
        public int Year { get; set; }
        public int Tons { get; set; }
        public int Index { get; set; }
        public int Numbre { get; set; }
        public Guid Uid { get; set; }
        public DateTime LastModification { get; set; }
        public  string ModifiedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Stor_Perde_Yikama.Models
{
    [Table("Galery")]
    public class Galery
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string filter_name { get; set; }

        public byte[] galery_pic { get; set; }

        [StringLength(30)]
        public string title { get; set; }

        [StringLength(30)]
        public string baslik { get; set; }

        [StringLength(30)]
        public string alt_baslik { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

    }
}
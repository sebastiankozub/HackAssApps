using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlWebApp.Models
{
    [Table("Url")]
    public class Url
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UrlId { get; set; }
        public string GivenUrl { get; set; } //with domain 
        public string ShortUrl { get; set; } //without domain
        public DateTime Created { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlsWebApp.Models
{
    [Table("Url")]
    public class Url
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UrlId { get; set; }
        [Required]
        public string GivenUrl { get; set; } //with domain 
        [Required]
        public string ShortUrl { get; set; } //without domain
        [Required]
        public DateTime Created { get; set; }
    }
}

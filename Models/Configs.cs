
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace blazorserversidetest3.Models
{
    public class Configs
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        
    }
}
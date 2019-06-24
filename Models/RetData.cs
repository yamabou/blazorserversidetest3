
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace blazorserversidetest3.Models
{
    [NotMapped]
    public class RetData
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }

        public string ken { get; set; }
        
    }
}
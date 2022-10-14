using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateCore.Models
{
    public class Person : BaseEntity<Int64>
    {
        [Required]
        public string Name { get; set; }
    }
}

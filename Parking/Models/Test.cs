using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class Test
    {

        public Guid Id { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
    }
}

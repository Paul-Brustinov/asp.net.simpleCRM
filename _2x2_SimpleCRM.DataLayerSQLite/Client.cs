using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2x2_SimpleCRM.DataLayerSQLite
{
    public partial class Client
    {
        [Key]
        [Required]
        public Int64 Id { get; set; }

        [Required]
        public String Name { get; set; }
    }
}

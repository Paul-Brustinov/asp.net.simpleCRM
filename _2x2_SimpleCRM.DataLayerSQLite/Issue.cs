using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2x2_SimpleCRM.DataLayerSQLite
{
    public partial class Issue
    {

        [Key]
        [Required]
        public Int64 Id { get; set; }

        [Required]
        public Int64 ClientId { get; set; }

        [Required]
        public String Name { get; set; }

    }
}

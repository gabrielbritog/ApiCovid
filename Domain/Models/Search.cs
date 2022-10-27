using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Search
    {
        public Guid Id { get; set; }
        public List<Countries> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}

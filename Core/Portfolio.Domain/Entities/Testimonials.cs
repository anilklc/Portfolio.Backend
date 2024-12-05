using Portfolio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class Testimonials : BaseEntity
    {
        public string ClientName { get; set; }
        public string ClientImage { get; set; }
        public string Comment { get; set; }
    }
}

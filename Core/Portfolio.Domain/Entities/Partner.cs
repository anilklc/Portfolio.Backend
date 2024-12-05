using Portfolio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class Partner : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}

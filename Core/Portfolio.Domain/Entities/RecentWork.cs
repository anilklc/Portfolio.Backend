using Portfolio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class RecentWork : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Url { get; set; }
    }
}

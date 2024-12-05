using Portfolio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
    }
}

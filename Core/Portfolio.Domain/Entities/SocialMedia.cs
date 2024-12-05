using Portfolio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class SocialMedia : BaseEntity
    {
        public string SocialMediaName { get; set; }
        public string SocialMediaIcon { get; set; }
        public string Url { get; set; }
    }
}

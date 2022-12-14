using System;
using System.Collections.Generic;

#nullable disable

namespace Tracking_Interface_API.Models
{
    public partial class VSTArticleDutyPaidRemain
    {
        public long id { get; set; }
        public string article_code { get; set; }
        public string article_code_duty_paid { get; set; }
        //public byte[] timestamp { get; set; }
    }
}

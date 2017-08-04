using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummyBearKingdomTokyo.Models
{
    public class UsersPost
    {
        public int postID { get; set; }
        public string subject { get; set; }
        public string Description { get; set; }
        public DateTime postDate { get; set; }
    }
}

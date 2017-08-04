using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummyBearKingdomTokyo.Models.ManageViewModels
{
    public class Forum
    {
        public int userID { get; set; }
        public string UserName { get; set; }
      //public DateTime date { get; set; } // Might need this later.

        public virtual ICollection<UsersPost> UsersPost { get; set; }
    }
}

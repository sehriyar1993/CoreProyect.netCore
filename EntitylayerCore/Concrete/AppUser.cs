using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitylayerCore.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }

        public List<Blog>? Blogs { get; set; }
        public virtual ICollection<MessageTwo> AppSender { get; set; }
        public virtual ICollection<MessageTwo> AppReciever { get; set; }

    }
}

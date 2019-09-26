using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        ///<value>Articles Id, effects Comment position on the page. PK</value>
        public int Id { get; set; }

        ///<value>Get/Set Path to users avatar</value>
        public string Avatar { get; set; }

        ///<value>Get/Set Name of the Comment</value>
        public string Name { get; set; }

        ///<value>Get/Set user Login</value>
        private string Login { get; set; }

        ///<value>Get/Set User password</value>
        private string Password { get; set; }
    }
}

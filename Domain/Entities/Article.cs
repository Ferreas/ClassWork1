using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Entity that represents articles posted on main page
    /// </summary>
    public class Article
    {
        ///<value>Articles Id, effects Articles position on the page. PK</value>
        public int Id { get; set; }

        ///<value>Get/Set Name of the Article</value>
        public string Name{ get; set; }
        ///<value>Get/Set Article Content</value>
        public string Content { get; set; }
        ///<value>Get/Set date of publishing</value>
        public DateTime PublishDate { get; set; }
    }
}

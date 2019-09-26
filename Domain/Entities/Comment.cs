using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Entity that represents Comment posted on comments section
    /// </summary>
    public class Comment
    {
        ///<value>Articles Id, effects Comment position on the page. PK</value>
        public int Id { get; set; }


       
        ///<value>Get/Set Name of the Comment</value>
        public string Name { get; set; }
        ///<value>Get/Set Link to avatar</value>
        public string Avatar { get; set; }
        ///<value>Get/Set Comment text</value>
        public string Content { get; set; }
        ///<value>Get/Set date of publishing the Comment</value>
        public DateTime PublishDate { get; set; }
    }
}

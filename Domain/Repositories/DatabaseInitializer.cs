using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<SystemContext>
    {
        protected override void Seed(SystemContext db)
        {
            //String with lorem placeholder
            string Lorem = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo. Quisque sit amet est et sapien ullamcorper pharetra. Vestibulum erat wisi, condimentum sed, commodo vitae, ornare sit amet, wisi. Aenean fermentum, elit eget tincidunt condimentum, eros ipsum rutrum orci, sagittis tempus lacus enim ac dui. Donec non enim in turpis pulvinar facilisis. Ut felis. Praesent dapibus, neque id cursus faucibus, tortor neque egestas augue, eu vulputate magna eros eu erat. Aliquam erat volutpat. Nam dui mi, tincidunt quis, accumsan porttitor, facilisis luctus, metus";

            //creating and adding some articles to the database
            Article Article1 = new Article() { Name = "Lorem Ipsum1", Content = Lorem, PublishDate = DateTime.Today };
            Article Article2 = new Article() { Name = "Lorem Ipsum2", Content = Lorem, PublishDate = DateTime.Today };
            db.Articles.Add(Article1);
            db.Articles.Add(Article2);

            //creating and adding some Users to the database
            User Chris = new User() { Name = "Chris Fox", Avatar = "/Content/Images/Parrot1.PNG" };
            User Rebecca = new User() { Name = "Rebecca Flex", Avatar = "/Content/Images/Parrot2.PNG" };
            db.Users.Add(Chris);
            db.Users.Add(Rebecca);

            //creating and adding some comments to the database
            Comment comment1 = new Comment() { Name = Chris.Name, Avatar = Chris.Avatar, Content = "My First comment", PublishDate = DateTime.Now };
            Comment comment2 = new Comment() { Name = Chris.Name, Avatar = Chris.Avatar, Content = "My Second comment", PublishDate = DateTime.Now };
            Comment comment3 = new Comment() { Name = Rebecca.Name, Avatar = Rebecca.Avatar, Content = "My First comment", PublishDate = DateTime.Now };
            Comment comment4 = new Comment() { Name = Rebecca.Name, Avatar = Rebecca.Avatar, Content = "My Second comment", PublishDate = DateTime.Now };
            db.Comments.Add(comment1);
            db.Comments.Add(comment2);
            db.Comments.Add(comment3);
            db.Comments.Add(comment4);

            db.SaveChanges();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingWebsite.Models;
using System.Data.Entity;

namespace WeddingWebsite.Repository
{
    public class DbHelper
    {
        public DbHelper()
        {

        }
        public List<Comment> GetCommentsAsync(){

            using (WeddingWebsiteDB context = new WeddingWebsiteDB()) { 
            var comments = (from c in context.Comments
                            orderby c.Id descending
                            select c).ToList();



            return comments;
        }
        }
    }
}

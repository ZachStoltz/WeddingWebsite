using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeddingWebsite.Models;
using WeddingWebsite.Repository;

namespace WeddingWebsiteMVC.Controllers
{
    public class CommentController : Controller
    {
        WeddingWebsiteDB context = new WeddingWebsiteDB();

        public ActionResult Index()
        {
            var comments = (from c in context.Comments
                            orderby c.Id descending
                            select c);

            var model = new Comment();
            model.Comments = comments;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Comment comment)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                comment.TimeStamp = now;
                context.Comments.Add(comment);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index", comment);
        }

        protected override void Dispose(bool disposing)
        {
            if (context != null)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

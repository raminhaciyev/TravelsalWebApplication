using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Controllers
{
    public class CommentController : Controller
    {
        CommentManager comment = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {

            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            comment.TAdd(p);
            return RedirectToAction("Index","Destination");

        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager comment = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = comment.TGetDestinationById(id);
            return View(values);
        }
    }
}

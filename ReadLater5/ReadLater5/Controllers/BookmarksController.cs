using Entity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadLater5.Controllers
{
    public class BookmarksController : Controller
    {
        private readonly IBookmarkService _bookmarksService;

        public BookmarksController(IBookmarkService bookmarksService)
        {
            _bookmarksService = bookmarksService;
        }

        // GET: Bookmarks
        public IActionResult Index()
        {
            List<Bookmark> model = _bookmarksService.GetBookmarks();
            return View(model);
        }

    }
}

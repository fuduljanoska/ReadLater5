using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class BookmarkService : IBookmarkService
    {
        private readonly ReadLaterDataContext _readLaterDataContext;

        public BookmarkService(ReadLaterDataContext readLaterDataContext)
        {
            _readLaterDataContext = readLaterDataContext;
        }
        public Bookmark CreateBookmark(Bookmark bookmark)
        {
            _readLaterDataContext.Add(bookmark);
            _readLaterDataContext.SaveChanges();
            return bookmark;
        }

        public void DeleteBookmark(Bookmark bookmark)
        {
            _readLaterDataContext.Bookmark.Remove(bookmark);
            _readLaterDataContext.SaveChanges();
        }

        public Bookmark GetBookmark(int id)
        {
            return _readLaterDataContext.Bookmark.Where(c => c.ID == id).FirstOrDefault();
        }

        public List<Bookmark> GetBookmarks()
        {
            return _readLaterDataContext.Bookmark.ToList();
        }

        public void UpdateBookmark(Bookmark bookmark)
        {
            _readLaterDataContext.Update(bookmark);
            _readLaterDataContext.SaveChanges();
        }
    }
}

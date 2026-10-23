using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Application.Mappings;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Services
{
    public class BookmarkService : IBookmarkService
    {


        private readonly IBookmarkRepository _bookmarkRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITweetRepository _tweetRepository;

        public BookmarkService(
            IBookmarkRepository bookmarkRepository,
            IUserRepository userRepository,
            ITweetRepository tweetRepository)
        {
            _bookmarkRepository = bookmarkRepository;
            _userRepository = userRepository;
            _tweetRepository = tweetRepository;
        }

        public BookmarkDto? CreateBookmark(CreateBookmarkDto createBookmarkDto)
        {
            if(_userRepository.GetUserById(createBookmarkDto.UserId) == null ||
                _tweetRepository.GetTweetById(createBookmarkDto.TweetId ) == null 
                )
            {
                return null;
            }

            var existingBookmark = _bookmarkRepository.GetBookmarkByUserAndTweet(
                createBookmarkDto.UserId, createBookmarkDto.TweetId);

            if (existingBookmark != null)
            {
                return existingBookmark.ToDto();
            }

            var createdBookmark = _bookmarkRepository.AddBookmark(new Bookmark()
            {
                UserId = createBookmarkDto.UserId,
                TweetId = createBookmarkDto.TweetId
            });

            return createdBookmark.ToDto();

        }

        public bool DeleteBookmark(Guid id)
        {
            var bookmark = _bookmarkRepository.GetBookmarkById(id);

            if (bookmark == null)
            {
                return false;
            }

            return _bookmarkRepository.DeleteBookmark(bookmark);
        }

        public BookmarkDto? GetBookmarkById(Guid id)
        {
            var bookmark = _bookmarkRepository.GetBookmarkById(id);

            return bookmark?.ToDto();
        }

        public List<BookmarkDto> GetBookmarks(Guid? userId)
        {
            return _bookmarkRepository.GetBookmarks(userId)
               .OrderByDescending(b => b.CreatedAt)
               .Select(b => b.ToDto())
               .ToList();
        }
    }
}

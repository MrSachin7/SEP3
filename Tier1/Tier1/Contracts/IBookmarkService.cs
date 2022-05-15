﻿using Entities.Models;

namespace Contracts;

public interface IBookmarkService
{
    Task AddBookmark(Bookmark bookmark);
    Task RemoveBookmark(Bookmark bookmark);
}
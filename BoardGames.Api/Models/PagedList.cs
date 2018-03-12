﻿using System.Collections.Generic;

namespace BoardGames.Api.Models
{
    public class PagedList<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}

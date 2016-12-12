using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationEpiserver.Models.ViewModels
{
    public class PaginationViewModel
    {
        private const string PaginationQuery = "p";
        public int CurrentIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int NumberOfPages { get; set; }
        public string BaseUrl { get; set; }

        public PaginationViewModel(int currentIndex, int pageSize, int totalItems)
        {
            CurrentIndex = currentIndex;
            TotalItems = totalItems;
            PageSize = pageSize;
            NumberOfPages = (int)Math.Ceiling((float)TotalItems / (float)PageSize);
            BaseUrl = BuildPaginationBaseUrl(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        private string BuildPaginationBaseUrl(string absoluteUrl)
        {
            var uri = new Uri(absoluteUrl);
            var queries = HttpUtility.ParseQueryString(uri.Query);
            queries.Remove(PaginationQuery);

            return queries.Count > 0 ? $"?{queries}" : string.Empty;
        }

        public string GetPaginationUrl(int page)
        {
            var queryCharacter = BaseUrl.Contains("?") ? "&" : "?";
            return $"{BaseUrl}{queryCharacter}{PaginationQuery}={page}";
        }

        public int GetVisablePagesStart()
        {
            int start;

            if (CurrentIndex > (NumberOfPages - 2))
                start = NumberOfPages - 4;
            else
                start = CurrentIndex - 2;

            if (start < 1)
                start = 1;

            return start;
        }

        public int GetVisablePagesEnd()
        {
            var start = GetVisablePagesStart();
            var end = start + 4;

            if (end > NumberOfPages)
                end = NumberOfPages;

            return end;
        }
    }
}
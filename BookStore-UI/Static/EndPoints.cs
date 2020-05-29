using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Static
{
    public static class EndPoints
    {
        public static string BaseUrl = "https://localhost:44340/";
        public static string AuthorsEndpoint = $"{BaseUrl }api/authors/";
        public static string BooksEndpoint = $"{BaseUrl }api/books/";
        public static string RegisterEndpoint = $"{BaseUrl }api/user/register";
        public static string LoginEndpoint = $"{BaseUrl }api/user/login";
    }
}

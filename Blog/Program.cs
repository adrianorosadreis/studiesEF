using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext;

            var posts = context.PostWithTagsCount.ToList();
            foreach(var item in posts)
            {
                Console.WriteLine(item.Count + item.Name);
            }
        }
    }
}
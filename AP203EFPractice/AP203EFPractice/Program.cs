using AP203EFPractice.Data.DAL;
using AP203EFPractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AP203EFPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Post post = new Post()
            //{
            //    Title = "post1",
            //    Content = "post content1"
            //};

            //AddPost(post);

            //AppDbContext dbContext = new AppDbContext();

            //var result = dbContext.Posts.FirstOrDefault(x => x.Title == "post1");
            //Console.WriteLine($"Id: {result.Id} - Title: {result.Title}");

            //Console.WriteLine(GetPostById(1).Title);

            //foreach (var item in GetAllPosts())
            //{
            //    Console.WriteLine(item.Title);
            //}

            //EditPostTitle(2, "post1 title");
            //DeletePost(1);

            //Employee employee = dbContext.Employees.Include(e => e.Department).ThenInclude(d => d.Company).FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee.Department.Company.Name);
        }

        public static void AddPost(Post post)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                dbContext.Posts.Add(post);
                dbContext.SaveChanges();
            }
        }
        public static Post GetPostById(int id)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                return dbContext.Posts.FirstOrDefault(p => p.Id == id);
            }
        }
        public static List<Post> GetAllPosts()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                return dbContext.Posts.ToList();
            }
        }
        public static void EditPostTitle(int id, string title)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                Post post = dbContext.Posts.FirstOrDefault(p => p.Id == id);
                if (post != null)
                {
                    post.Title = title;
                    dbContext.SaveChanges();
                }
            }
        }
        public static void DeletePost(int id)
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                Post post = dbContext.Posts.FirstOrDefault(p => p.Id == id);
                if(post != null)
                {
                    dbContext.Posts.Remove(post);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}

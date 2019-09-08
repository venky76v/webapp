using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp
{
    public class ArticleRepository
    {
        private List<Article> articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "What is Lorem Ipsum?",
                Author= "Venky Venkataraman",
                PublishedOn = new DateTime(2019, 01, 20),
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Article
            {
                Id =  2,
                Title = "Why do we use it?",
                Author= "Venky Venkataraman",
                PublishedOn = new DateTime(2019, 01, 21),
                Content = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."
            },
            new Article
            {
                Id = 3,
                Title = "Where does it come from?",
                Author= "Venky Venkataraman",
                PublishedOn = new DateTime(2019, 01, 22),
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old."
            },
            new Article
            {
                Id = 4,
                Title = "Yet another article",
                Author= "Venky Venkataraman",
                PublishedOn = new DateTime(2019, 03, 27),
                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old."
            },
            new Article
            {
                Id = 5,
                Title = "What is Docker",
                Author= "Venky Venkataraman",
                PublishedOn = DateTime.Now,
                Content = "It works on my machine but it doesn't work on the production server. Docker is a software platform for building applications based on containers — small and lightweight execution environments that make shared use of the operating system kernel but otherwise run in isolation from one another. While containers as a concept have been around for some time, Docker, an open source project launched in 2013, helped popularize the technology, and has helped drive the trend towards containerization and microservices in software development that has come to be known as cloud-native development"
            },
        };

        public Article GetArticle(int id)
        {
            var article = articles.FirstOrDefault(a => a.Id == id);

            if (article == null)
            {
                article = new Article();
            }
            return article;
        }

        public List<Article> GetLatest()
        {
            return articles;
        }
    }
}

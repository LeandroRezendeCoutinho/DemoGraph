
using System.Collections.Generic;

namespace DemoGraph.GraphQL
{
    public class Query
    {
        public Book GetBook() =>
            new Book
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };

        public List<Book> GetBooks()
        {
            var list = new List<Book>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(
                    new Book
                    {
                        Title = "C# in depth.",
                        Author = new Author
                        {
                            Name = "Jon Skeet"
                        }
                    }
                );
            }

            return list;
        }
    }
}
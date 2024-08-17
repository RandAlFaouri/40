namespace ASP06.MinimalApi.Models.Services
{
    public class BookService : IBookService 
    {
        public async Task<List<Book>> GetAll()
        {
            await Task.Delay(Random.Shared.Next(500, 3000));

            var books = new List<Book>
            {
                new Book { Id = 1,Title="Clean Code",Authors= "Robert C. Martin"},
                 new Book { Id = 2, Title = "The Pramatic Programmer", Authors = "Andrew C. George" },
                  new Book { Id = 3, Title = "Desing Patterns: Elemnts of Reusable Object ", Authors = "Erich C. Gamma" },
                   new Book { Id = 4, Title = "Refactoring:Improving the desgin of Existing code", Authors = "Martin C. Fowler" },
                    new Book { Id = 5, Title = "Code Complete", Authors = "Steve McConnell" },
                     new Book { Id = 6, Title = "Continuous Delivery : Reliable Software Releases Through Build,Test,and Deployment Automation ", Authors = "Jez Humble" },
                      new Book { Id = 7, Title = "The Mythical Man-Month:Essays on Software Engineering", Authors = "Fred Brooks" },
                       new Book { Id = 8, Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software", Authors = "Eric Evans" },
                       new Book { Id = 9, Title = "Software Engineering at Google: Lessons Learned from Programming Over Time", Authors = "Titus Winters" },
            new Book { Id = 10, Title = "Working Effectively with Legacy Code", Authors = "Michael C. Feathers" }
                       };
            return books;
        }
    }
}

using System.Linq;
using AndreyProg.Models;

namespace AndreyProg
{
    public static class SampleData
    {
        public static void Init (BookContext context)
        {
            if(!context.Books.Any())
            {
                context.Books.AddRange(new Book{Name = "Harri Potter", Author = "Roling", Price = 200});
                context.SaveChanges();
            }

        }
    }
}
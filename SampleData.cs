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
                context.Books.AddRange(new Book{Name = "Harri Potter ", Author = "Roling", Price = 200});
                context.Books.AddRange(new Book{Name = "main and war  ", Author = "Girniy", Price = 700});
                context.Books.AddRange(new Book{Name = "Little Fires Everywhere ", Author = " Celeste Ng", Price = 10});
                context.Books.AddRange(new Book{Name = "Into the Water", Author = " Paula Hawkins ", Price = 40});
                context.Books.AddRange(new Book{Name = "The Hate U Give ", Author = "Angie Thomas ", Price = 100});
                context.Books.AddRange(new Book{Name = "Turtles All the Way Down ", Author = "John Green", Price = 900});
                context.Books.AddRange(new Book{Name = "Before We Were Yours ", Author = " Lisa Wingate ", Price = 7200});
                context.Books.AddRange(new Book{Name = "Eleanor Oliphant Is Completely Fine ", Author = "Gail Honeyman ", Price = 400});
                context.Books.AddRange(new Book{Name = "Artemis ", Author = "Andy Weir ", Price = 200});
                context.Books.AddRange(new Book{Name = "Norse Mythology ", Author = "Neil Gaiman", Price = 700});
                context.Books.AddRange(new Book{Name = "Lincoln in the Bardo ", Author = "George Saunders ", Price = 14});
                context.SaveChanges();
            }

        }
    }
}
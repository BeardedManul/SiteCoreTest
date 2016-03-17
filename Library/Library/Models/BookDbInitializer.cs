using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 30 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 20 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 15 });
            db.Books.Add(new Book { Name = "Властелин Колец", Author = "Д.Р.Р. Толкин", Price = 30});

            base.Seed(db);
        }
    }
}
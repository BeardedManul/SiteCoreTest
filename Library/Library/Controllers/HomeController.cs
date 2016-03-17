using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        int ID = 0;

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            ID = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            var book = db.Books.Find(purchase.BookId);

            if (book.IsTaken == false)
            {
                book.Taken = book.Taken + 1;
                book.IsTaken = true;
                book.TakenByWho = purchase.Person;

                purchase.Date = DateTime.Now;

                // добавляем информацию о покупке в базу данных
                db.Purchases.Add(purchase);
                // сохраняем в бд все изменения
                db.SaveChanges();

                return "Спасибо, " + purchase.Person + ", за покупку!";   
            }

            return "Уважаемый " + purchase.Person + ", приносим свои извинения, но книга уже взята.";
        }
    }
}
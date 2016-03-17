using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // цена
        public int Price { get; set; }
        // количество взятий книги
        public int Taken { get; set; }
        // взята ли сейчас
        public bool IsTaken { get; set; }
        // если взята, то кем
        public string TakenByWho { get; set; }
    }
}
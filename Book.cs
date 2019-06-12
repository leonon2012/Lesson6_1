using System;

namespace Lesson6
{
    class Book
    {
        // Поля
        string name;
        ushort pages;
        public Author Author;


        public string Name { get => name; set => name = value.Trim(); }
        public ushort Pages { get => pages; set => pages = value; }

        public Book()
        {
            Author = new Author();
        }

        public Book(string name, ushort pages, Author author)
        {
            Name = name;
            Pages = pages;
            Author = author;
        }

        public override string ToString()
        {
            return $"{name}\n" + Author + "\n" + pages + " стр.";
        }
    }
}

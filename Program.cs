using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book B = new Book("Мервые не потеют", 300, new Author("ИваноВ иВаН иВАНОВИЧ", 1));
            Console.WriteLine(B);
        }
    }
}

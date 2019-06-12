using System;

namespace Lesson6
{
    class Author
    {
        // Поля
        string name;
        byte sex;

        // Свойства
        public string Name { get => name; set => name = FirstToUpper(value); }
        public byte Sex { get => sex; set => sex = (value > 2 | value < 0 ? (byte)0 : value); }

        // Первая буква заглавная
        public static string FirstToUpper(string s)
        {
            char[] mas = s.Trim().ToCharArray();
            bool flag = true;

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = flag && char.IsLetter(mas[i]) ? char.ToUpper(mas[i]) : char.ToLower(mas[i]);
                flag = char.IsLetter(mas[i]) ? false : true;
            }

            return string.Join("", mas);
        }

        // Перекрываем метод
        public override string ToString()
        {
            return $"Автор: " + (sex == 0 ? "" : (sex == 1 ? "пан " : "пани ")) + name;
        }

        // Конструктор
        public Author() : this("noname")
        {            
        }

        public Author(string name)
        {
            Name = name;
        }

        public Author(string name, byte sex) : this(name)
        {
            Sex = sex;
        }
    }
}

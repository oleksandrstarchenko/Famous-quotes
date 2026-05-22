using System;

namespace FamousQuotesApp
{
    public class Quote
    {
        // Текст самого вислову
        public string Text { get; set; }

        // Автор вислову
        public string Author { get; set; }

        // Категорія (наприклад: Філософія, Спорт тощо)
        public string Category { get; set; }

        // Нове поле: рейтинг вислову (наприклад, від 1 до 5)
        public int Rating { get; set; }


        // Конструктор для зручного створення об'єкта цитати
        public Quote(string text, string author, string category, int rating)
        {
            Text = text;
            Author = author;
            Category = category;
            Rating = rating;
        }

        // Порожній конструктор
        public Quote() { }
    }
}
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

        // Конструктор для зручного створення об'єкта цитати
        public Quote(string text, string author, string category)
        {
            Text = text;
            Author = author;
            Category = category;
        }

        // Порожній конструктор
        public Quote() { }
    }
}
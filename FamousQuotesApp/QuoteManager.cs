using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Потрібно для роботи з JSON

namespace FamousQuotesApp
{
    public class QuoteManager
    {
        // Наш список, де зберігаються всі цитати під час роботи програми
        public List<Quote> Quotes { get; private set; }

        // Шлях до файлу, де все буде зберігатися на диску
        private readonly string filePath = "quotes.json";

        public QuoteManager()
        {
            Quotes = new List<Quote>();
            LoadFromFile(); // Автоматично завантажуємо дані при старті
        }

        // Метод для додавання нової цитати
        public void AddQuote(Quote quote)
        {
            Quotes.Add(quote);
            SaveToFile(); // Одразу зберігаємо зміни у файл
        }

        // Метод для видалення цитати
        public void DeleteQuote(Quote quote)
        {
            Quotes.Remove(quote);
            SaveToFile(); // Одразу зберігаємо зміни у файл
        }

        // Збереження списку у файл JSON
        public void SaveToFile()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(Quotes, options);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                // Якщо щось піде не так, програма не вилетить, а покаже помилку
                System.Windows.Forms.MessageBox.Show($"Помилка збереження файлу: {ex.Message}");
            }
        }

        // Завантаження списку з файлу JSON
        public void LoadFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    Quotes = JsonSerializer.Deserialize<List<Quote>>(jsonString) ?? new List<Quote>();
                }
            }
            catch
            {
                Quotes = new List<Quote>(); // Якщо файл пошкоджений, просто створимо пустий список
            }
        }
    }
}
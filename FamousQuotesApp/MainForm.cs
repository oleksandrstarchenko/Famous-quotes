using System;
using System.Windows.Forms;

namespace FamousQuotesApp
{
    public partial class MainForm : Form
    {
        // Створюємо об'єкт менеджера, який керує списком цитат та файлом JSON
        private QuoteManager quoteManager;

        public MainForm()
        {
            InitializeComponent();
            quoteManager = new QuoteManager(); // Ініціалізуємо його
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTable(); // При запуску програми одразу виводимо цитати в таблицю
        }

        // Метод, який бере список цитат і красиво запихує їх в нашу таблицю dgvQuotes
        private void UpdateTable()
        {
            dgvQuotes.DataSource = null; // Скидаємо стару наявну інформацію
            dgvQuotes.DataSource = quoteManager.Quotes; // Прив'язуємо оновлений список

            // Робимо таблицю красивішою: перейменовуємо заголовки стовпчиків
            if (dgvQuotes.Columns["Text"] != null) dgvQuotes.Columns["Text"].HeaderText = "Текст вислову";
            if (dgvQuotes.Columns["Author"] != null) dgvQuotes.Columns["Author"].HeaderText = "Автор";
            if (dgvQuotes.Columns["Category"] != null) dgvQuotes.Columns["Category"].HeaderText = "Категорія";

            // Автоматично розтягуємо стовпчики по ширині вікна
            dgvQuotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Відкриваємо форму додавання
            EditQuoteForm editForm = new EditQuoteForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Якщо користувач у другому вікні натиснув "Зберегти",
                // ми заберемо створену цитату і додамо її в менеджер
                quoteManager.AddQuote(editForm.NewQuote);
                UpdateTable(); // Перемальовуємо таблицю, щоб нова цитата з'явилася на екрані
            }
        }
    }
}

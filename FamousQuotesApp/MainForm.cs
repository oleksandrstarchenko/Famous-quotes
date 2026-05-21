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
            quoteManager = new QuoteManager();// Ініціалізуємо його
            txtSearch.TextChanged += txtSearch_TextChanged;// Кажемо програмі: "Коли текст у полі txtSearch змінюється, виконуй метод txtSearch_TextChanged"
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи користувач взагалі вибрав якийсь рядок
            if (dgvQuotes.SelectedRows.Count > 0)
            {
                // Виводимо віконце з питанням: Так чи Ні?
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей вислів?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Беремо об'єкт цитати прямо з вибраного рядка таблиці
                    Quote quoteToDelete = (Quote)dgvQuotes.SelectedRows[0].DataBoundItem;

                    // Передаємо цю цитату нашому менеджеру на видалення (він сам перезапише файл json)
                    quoteManager.DeleteQuote(quoteToDelete);

                    // Оновлюємо таблицю на екрані, щоб рядок зник
                    UpdateTable();
                }
            }
            else
            {
                // Якщо нічого не вибрано, просто попереджаємо
                MessageBox.Show("Будь ласка, виберіть цитату для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Сюди вставляй весь той великий код пошуку, який я дав у попередньому повідомленні
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                UpdateTable();
            }
            else
            {
                var filteredQuotes = quoteManager.Quotes.FindAll(q =>
                    (q.Text != null && q.Text.ToLower().Contains(searchText)) ||
                    (q.Author != null && q.Author.ToLower().Contains(searchText))
                );

                dgvQuotes.DataSource = null;
                dgvQuotes.DataSource = filteredQuotes;

                if (dgvQuotes.Columns["Text"] != null) dgvQuotes.Columns["Text"].HeaderText = "Текст вислову";
                if (dgvQuotes.Columns["Author"] != null) dgvQuotes.Columns["Author"].HeaderText = "Автор";
                if (dgvQuotes.Columns["Category"] != null) dgvQuotes.Columns["Category"].HeaderText = "Категорія";
                dgvQuotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}

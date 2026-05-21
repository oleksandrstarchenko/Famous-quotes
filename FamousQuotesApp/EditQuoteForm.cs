using System;
using System.Windows.Forms;

namespace FamousQuotesApp
{
    public partial class EditQuoteForm : Form
    {
        // Ця властивість дозволить головній формі забрати нову цитату
        public Quote NewQuote { get; private set; }

        public EditQuoteForm()
        {
            InitializeComponent();

            // Додаємо варіанти у випадаючий список категорій
            cmbCategory.Items.AddRange(new string[] { "Філософія", "Наука", "Мотивація", "Мистецтво", "Спорт" });
            cmbCategory.SelectedIndex = 0; // Вибираємо перший варіант за замовчуванням
        }

        // Логіка кнопки "Зберегти"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи користувач ввів текст
            if (string.IsNullOrWhiteSpace(txtText.Text) || string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Будь ласка, заповніть текст цитати та автора!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Створюємо нову цитату з введених даних
            NewQuote = new Quote(txtText.Text, txtAutor.Text, cmbCategory.Text);

            // Кажемо програмі, що все пройшло успішно (OK) і закриваємо вікно
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Цей метод закине дані цитати в текстові поля при редагуванні
        public void LoadQuoteData(Quote quote)
        {
            txtText.Text = quote.Text;
            txtAutor.Text = quote.Author;
            cmbCategory.Text = quote.Category;
        }
    }
}

namespace FamousQuotesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр форми для додавання/редагування
            EditQuoteForm editForm = new EditQuoteForm();

            // Відкриваємо її як модальне вікно 
            // (воно заблокує головне вікно, поки користувач його не закриє)
            editForm.ShowDialog();

        }
    }
}

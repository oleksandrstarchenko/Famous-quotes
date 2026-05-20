using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FamousQuotesApp
{
    public partial class EditQuoteForm : Form
    {
        public EditQuoteForm()
        {
            InitializeComponent();
        }

        private void EditQuoteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Просто закриваємо це модальне вікно без збереження даних
            this.Close();
        }
    }
}

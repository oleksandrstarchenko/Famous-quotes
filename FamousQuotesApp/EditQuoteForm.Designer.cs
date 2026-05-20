namespace FamousQuotesApp
{
    partial class EditQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtText = new TextBox();
            txtAutor = new TextBox();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtText
            // 
            txtText.Location = new Point(126, 6);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(257, 347);
            txtText.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(516, 100);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(272, 27);
            txtAutor.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(516, 205);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(272, 28);
            cmbCategory.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(574, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(694, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Текст вислову:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 107);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Автор:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 208);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Категорія:";
            // 
            // EditQuoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(txtAutor);
            Controls.Add(txtText);
            Name = "EditQuoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання/Редагування вислову";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtText;
        private TextBox txtAutor;
        private ComboBox cmbCategory;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
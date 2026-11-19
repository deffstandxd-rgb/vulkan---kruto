using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string filePath = txtMyInput.Text.Trim();

            // Користувач не вказав шлях до файлу
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show(
                    "Ви не вказали шлях до файлу. Введіть шлях у поле (наприклад: D:\\test.txt).",
                    "Не вказано шлях",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Читаємо вміст файлу
                string fileContent = File.ReadAllText(filePath);

                txtFileContent.Text = fileContent;
                //MessageBox.Show(filePath, "Повідомлення!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(
                    $"Файл не знайдено за шляхом:\n{filePath}\nПеревірте назву файлу та чи існує він.",
                    "Файл не знайдено",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(
                    $"Невірний шлях до файлу — вказану папку не знайдено:\n{filePath}",
                    "Невірний шлях",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    $"Немає доступу до файлу:\n{filePath}\nМожливо, вказано шлях до папки замість файлу.",
                    "Немає доступу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                    $"Невірний формат шляху до файлу:\n{filePath}\nПеревірте символи у шляху.",
                    "Невірний шлях",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    $"Помилка під час читання файлу:\n{ex.Message}",
                    "Помилка читання",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Сталася помилка:\n{ex.Message}",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
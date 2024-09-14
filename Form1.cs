using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomSequenceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Викликається при завантаженні форми
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Обробник для кнопки "Згенерувати"
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Очищення попередніх значень у списках
            lstOriginalData.Items.Clear();
            lstCumulativeFrequency.Items.Clear();
            lstDistribution.Items.Clear();
            lstRelativeFrequency.Items.Clear();
            lstSortedData.Items.Clear();

            int N = 0, sequenceSize = 0;
            int[] sequence = { 0 };

            // Перевірка введеного номера студента
            if (int.TryParse(txtStudentNumber.Text, out N))
            {
                Random r = new Random();

                // Визначення розміру ряду за формулою S = N + 10
                sequenceSize = N + 10;

                // Створення масиву для зберігання ряду
                sequence = new int[sequenceSize];

                // Генерування послідовності випадкових чисел від 1 до 5
                for (int i = 0; i < sequenceSize; i++)
                {
                    sequence[i] = r.Next(1, 6);
                }

                // Виведення оригінальних даних у список
                foreach (var item in sequence)
                {
                    lstOriginalData.Items.Add(item);
                }

                // Відсортовуємо послідовність
                Array.Sort(sequence);

                // Виведення відсортованих даних у список
                foreach (var item in sequence)
                {
                    lstSortedData.Items.Add(item);
                }

                // Групування даних для створення статистичного розподілу
                var dist = sequence.GroupBy(x => x)
                                 .Select(g => new
                                 {
                                     Value = g.Key,
                                     Frequency = g.Count()
                                 });

                // Виведення статистичного розподілу у список
                foreach (var item in dist)
                {
                    lstDistribution.Items.Add($"Для {item.Value}: {item.Frequency} разів.");
                }

                // Розрахунок накопиченої частоти
                int accumFrequency = 0;
                foreach (var item in dist)
                {
                    accumFrequency += item.Frequency;
                    lstCumulativeFrequency.Items.Add($"Для {item.Value}: {accumFrequency}");
                }

                // Розрахунок відносної частоти
                foreach (var item in dist)
                {
                    double relFrequency = (double)item.Frequency / sequenceSize;
                    lstRelativeFrequency.Items.Add($"Для {item.Value}: {relFrequency}");
                }

                // Побудова полігону для статистичного розподілу
                Series seriesDist = new Series("Полігон розподілу");
                seriesDist.ChartType = SeriesChartType.Line;
                foreach (var item in dist)
                {
                    seriesDist.Points.AddXY(item.Value, item.Frequency);
                }
                chartDistribution.Series.Add(seriesDist);

                // Побудова полігону для відносної частоти
                Series seriesRelFreq = new Series("Відносна частота");
                seriesRelFreq.ChartType = SeriesChartType.Line;
                foreach (var item in dist)
                {
                    double relFrequency = (double)item.Frequency / sequenceSize;
                    seriesRelFreq.Points.AddXY(item.Value, relFrequency);
                }
                chartDistribution.Series.Add(seriesRelFreq);
            }
            else
            {
                // Повідомлення про помилку, якщо номер студента введений некоректно
                MessageBox.Show("Введіть коректний номер студента.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник для кнопки "Зберегти результати"
        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Налаштування діалогового вікна збереження
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Збережіть результати";
                saveFileDialog.FileName = "RandomSequenceResults.xlsx";

                // Якщо користувач вибрав файл для збереження
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Встановлюємо контекст ліцензії для EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    // Використання EPPlus для створення Excel файлу
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Створюємо новий аркуш Excel
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Results");

                        // Додаємо заголовки для колонок
                        worksheet.Cells[1, 1].Value = "Вихідні дані";
                        worksheet.Cells[1, 2].Value = "Відсортовані дані";
                        worksheet.Cells[1, 3].Value = "Розподіл";
                        worksheet.Cells[1, 4].Value = "Накопичена частота";
                        worksheet.Cells[1, 5].Value = "Відносна частота";

                        // Перевірка, чи є дані для збереження
                        if (lstOriginalData.Items.Count == 0 && lstSortedData.Items.Count == 0 &&
                            lstDistribution.Items.Count == 0 && lstCumulativeFrequency.Items.Count == 0 &&
                            lstRelativeFrequency.Items.Count == 0)
                        {
                            MessageBox.Show("Дані відсутні для збереження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Змінна для індексації рядків
                        int row = 2;

                        // Заповнення вихідними даними
                        for (int i = 0; i < lstOriginalData.Items.Count; i++)
                        {
                            worksheet.Cells[row, 1].Value = lstOriginalData.Items[i].ToString();
                            row++;
                        }

                        // Заповнення відсортованими даними
                        row = 2;
                        for (int i = 0; i < lstSortedData.Items.Count; i++)
                        {
                            worksheet.Cells[row, 2].Value = lstSortedData.Items[i].ToString();
                            row++;
                        }

                        // Заповнення даними розподілу
                        row = 2;
                        for (int i = 0; i < lstDistribution.Items.Count; i++)
                        {
                            worksheet.Cells[row, 3].Value = lstDistribution.Items[i].ToString();
                            row++;
                        }

                        // Заповнення накопиченою частотою
                        row = 2;
                        for (int i = 0; i < lstCumulativeFrequency.Items.Count; i++)
                        {
                            worksheet.Cells[row, 4].Value = lstCumulativeFrequency.Items[i].ToString();
                            row++;
                        }

                        // Заповнення відносною частотою
                        row = 2;
                        for (int i = 0; i < lstRelativeFrequency.Items.Count; i++)
                        {
                            worksheet.Cells[row, 5].Value = lstRelativeFrequency.Items[i].ToString();
                            row++;
                        }

                        // Збереження Excel файлу
                        FileInfo fileInfo = new FileInfo(filePath);
                        try
                        {
                            excelPackage.SaveAs(fileInfo);
                            MessageBox.Show("Результати успішно збережені у Excel файл!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Повідомлення про помилку збереження
                            MessageBox.Show($"Помилка збереження файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
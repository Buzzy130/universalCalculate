using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace universalCalculate
{

    public partial class pnumber : Form
    {
        public pnumber()
        {
            InitializeComponent();
        }

        TMemory memory = new TMemory();
        TANumber recalledNumber;

        private void BtnNumberClicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            // this.label1.Text = button.Text;
            if (label1.Text == "0")
                label1.Text = button.Text;
            else
                label1.Text += button.Text;
        }

        public void Parsing(string textBoxContent)
        {
            string text = textBoxContent;

            // Переменная для хранения результата операций
            TANumber result = null;

            // Разделители
            char[] delimiters = { '+', '-', '*', '/' };

            // Разбиваем строку на части по разделителям
            string[] parts = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Проверяем, что получаем ровно две части
            if (parts.Length == 2)
            {
                // Получаем левое и правое числа
                int leftNumber = int.Parse(parts[0]);
                int rightNumber = int.Parse(parts[1]);

                // Создаем объекты TPNumber
                TPNumber number1 = new TPNumber(leftNumber.ToString(), trackBar1.Value);
                TPNumber number2 = new TPNumber(rightNumber.ToString(), trackBar1.Value);

                // Определяем операцию в зависимости от знака
                if (text.Contains("+"))
                {
                    result = number1.Add(number2);
                }
                else if (text.Contains("-"))
                {
                    result = number1.Subtract(number2);
                }
                else if (text.Contains("*"))
                {
                    result = number1.Multiply(number2);
                }
                else if (text.Contains("/"))
                {
                    if (rightNumber != 0)
                    {
                        result = number1.Divide(number2);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                        return;
                    }
                }

                // Выводим результат операции
                label1.Text = result.ToString();
            }
            else
            {
                Console.WriteLine("Ошибка: В строке должен быть только один знак");
            }
        }






        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
                label1.Text = button1.Text;
            else
                label1.Text += button1.Text;

        }

        private void pnumber_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
                label1.Text = button2.Text;
            else
                label1.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value >= 3)
            {
                if (label1.Text == "0")
                    label1.Text = button3.Text;
                else
                    label1.Text += button3.Text;
            }
            else
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 4)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button4.Text;
                else
                    label1.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 5)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button5.Text;
                else
                    label1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 6)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button6.Text;
                else
                    label1.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 7)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button7.Text;
                else
                    label1.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 8)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button8.Text;
                else
                    label1.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 9)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button9.Text;
                else
                    label1.Text += button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 10)
            {
                MessageBox.Show("Проверьте систему счисления в которой работаете");
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = button10.Text;
                else
                    label1.Text += button10.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;
            int index = labelText.IndexOfAny(new[] { '+', '-', '*', '/' });
            if (index != -1)
            {
                label1.Text = labelText.Substring(0, index + 1);
            }
            else
            {
                label1.Text = "0";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, содержит ли текст хотя бы один из допустимых символов
            if (!text.Contains("+") && !text.Contains("-") && !text.Contains("*") && !text.Contains("/"))
            {
                // Если не содержит ни одного из символов, добавляем символ по умолчанию
                label1.Text += "+";
            }
            else
            {
                Parsing(text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string text = label1.Text;
            Parsing(text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, содержит ли текст хотя бы один из допустимых символов
            if (!text.Contains("+") && !text.Contains("-") && !text.Contains("*") && !text.Contains("/"))
            {
                // Если не содержит ни одного из символов, добавляем символ по умолчанию
                label1.Text += "-";
            }
            else
            {
                Parsing(text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, содержит ли текст хотя бы один из допустимых символов
            if (!text.Contains("+") && !text.Contains("-") && !text.Contains("*") && !text.Contains("/"))
            {
                // Если не содержит ни одного из символов, добавляем символ по умолчанию
                label1.Text += "*";
            }
            else
            {
                Parsing(text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, содержит ли текст хотя бы один из допустимых символов
            if (!text.Contains("+") && !text.Contains("-") && !text.Contains("*") && !text.Contains("/"))
            {
                // Если не содержит ни одного из символов, добавляем символ по умолчанию
                label1.Text += "/";
            }
            else
            {
                Parsing(text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)//вставить в память
        {
            string text = label1.Text;
            int number1;
            if (int.TryParse(text, out number1))
            {
                // Если строка содержит только число, выполняем необходимые действия
                TPNumber number = new TPNumber(text, trackBar1.Value);
                memory.Store(number);
                recalledNumber = memory.Recall();
                Console.WriteLine($"Recalled number: {recalledNumber}");
            }
            else
            {
                // Если строка не содержит только число, выводим сообщение об ошибке
                Console.WriteLine("Ошибка: Строка содержит лишние элементы.");
            }
        }

        private void button20_Click(object sender, EventArgs e)// достать из памяти
        {

        }

        private void button21_Click(object sender, EventArgs e)//отчистить память
        {
            // Clearing memory
            memory.Clear();
            recalledNumber = memory.Recall(); // Should throw exception
        }
    }
}

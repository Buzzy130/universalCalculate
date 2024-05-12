using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using universalCalculate;

namespace universalCalculate
{
    public partial class complex : Form
    {
        public complex()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button14.Text;
            else
                label1.Text += button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button13.Text;
            else
                label1.Text += button13.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button9.Text;
            else
                label1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button10.Text;
            else
                label1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button11.Text;
            else
                label1.Text += button11.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button5.Text;
            else
                label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button6.Text;
            else
                label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button7.Text;
            else
                label1.Text += button7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button1.Text;
            else
                label1.Text += button1.Text;
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
            if (label1.Text == "0")
                label1.Text = button3.Text;
            else
                label1.Text += button3.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button15.Text;
            else
                label1.Text += button15.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button17.Text;
            else
                label2.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button18.Text;
            else
                label2.Text += button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button19.Text;
            else
                label2.Text += button19.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button21.Text;
            else
                label2.Text += button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button22.Text;
            else
                label2.Text += button22.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button23.Text;
            else
                label2.Text += button23.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button25.Text;
            else
                label2.Text += button25.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button26.Text;
            else
                label2.Text += button26.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button27.Text;
            else
                label2.Text += button27.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button29.Text;
            else
                label2.Text += button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button30.Text;
            else
                label2.Text += button30.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
                label2.Text = button31.Text;
            else
                label2.Text += button31.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label2.Text))
            {
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button24_Click(object sender, EventArgs e)
        {
            string labelText = label2.Text;
            int index = labelText.IndexOfAny(new[] { '+', '-', '*', '/' });
            if (index != -1)
            {
                label2.Text = labelText.Substring(0, index + 1);
            }
            else
            {
                label2.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка не выполняет никаких операций!");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка не выполняет никаких операций!");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, что строка не пуста
            if (!string.IsNullOrEmpty(text))
            {
                // Проверяем, что строка не пуста
                if (!string.IsNullOrEmpty(text))
                {
                    // Находим индекс знака "+"
                    int indexOfPlus = text.IndexOf("+");

                    // Проверяем, что знак "+" найден и не является последним символом в строке
                    if (indexOfPlus != -1 && indexOfPlus < text.Length - 1)
                    {
                        // Получаем символ, следующий за знаком "+"
                        char nextChar = text[indexOfPlus + 1];

                        // Проверяем, является ли этот символ "i"
                        if (nextChar == 'i')
                        {
                            // Если символ после "+" - "i", выводим сообщение об ошибке
                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                        }
                        else
                        {
                            // Если символ после "+" не "i", все в порядке
                            string text2 = label2.Text;

                            // Проверяем, что строка не пуста
                            if (!string.IsNullOrEmpty(text))
                            {

                                // Проверяем, что строка не пуста
                                if (!string.IsNullOrEmpty(text))
                                {
                                    // Находим индекс знака "+"
                                    int indexOfPlus2 = text.IndexOf("+");

                                    // Проверяем, что знак "+" найден и не является последним символом в строке
                                    if (indexOfPlus2 != -1 && indexOfPlus2 < text.Length - 1)
                                    {
                                        // Получаем символ, следующий за знаком "+"
                                        char nextChar2 = text[indexOfPlus2 + 1];

                                        // Проверяем, является ли этот символ "i"
                                        if (nextChar2 == 'i')
                                        {
                                            // Если символ после "+" - "i", выводим сообщение об ошибке
                                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                                        }
                                        else
                                        {
                                            // Если символ после "+" не "i", все в порядке
                                            TComp comp1 = new TComp(label1.Text);
                                            TComp comp2 = new TComp(label2.Text);

                                            // Addition
                                            TANumber sum = comp1.Add(comp2);
                                            MessageBox.Show($"Addition: {comp1} + {comp2} = {sum}");



                                        }
                                    }
                                    else
                                    {
                                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                                    }
                                }
                                else
                                {
                                    // Если строка пуста, выводим сообщение об ошибке
                                    MessageBox.Show("Строка пуста.");
                                }
                            }
                            else
                            {
                                // Если строка пуста, выводим сообщение об ошибке
                                Console.WriteLine("Ошибка: Строка пуста.");
                            }
                        }
                    }
                    else
                    {
                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                    }
                }
                else
                {
                    // Если строка пуста, выводим сообщение об ошибке
                    MessageBox.Show("Строка пуста.");
                }
            }
            else
            {
                // Если строка пуста, выводим сообщение об ошибке
                Console.WriteLine("Ошибка: Строка пуста.");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, что строка не пуста
            if (!string.IsNullOrEmpty(text))
            {
                // Проверяем, что строка не пуста
                if (!string.IsNullOrEmpty(text))
                {
                    // Находим индекс знака "+"
                    int indexOfPlus = text.IndexOf("+");

                    // Проверяем, что знак "+" найден и не является последним символом в строке
                    if (indexOfPlus != -1 && indexOfPlus < text.Length - 1)
                    {
                        // Получаем символ, следующий за знаком "+"
                        char nextChar = text[indexOfPlus + 1];

                        // Проверяем, является ли этот символ "i"
                        if (nextChar == 'i')
                        {
                            // Если символ после "+" - "i", выводим сообщение об ошибке
                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                        }
                        else
                        {
                            // Если символ после "+" не "i", все в порядке
                            string text2 = label2.Text;

                            // Проверяем, что строка не пуста
                            if (!string.IsNullOrEmpty(text))
                            {

                                // Проверяем, что строка не пуста
                                if (!string.IsNullOrEmpty(text))
                                {
                                    // Находим индекс знака "+"
                                    int indexOfPlus2 = text.IndexOf("+");

                                    // Проверяем, что знак "+" найден и не является последним символом в строке
                                    if (indexOfPlus2 != -1 && indexOfPlus2 < text.Length - 1)
                                    {
                                        // Получаем символ, следующий за знаком "+"
                                        char nextChar2 = text[indexOfPlus2 + 1];

                                        // Проверяем, является ли этот символ "i"
                                        if (nextChar2 == 'i')
                                        {
                                            // Если символ после "+" - "i", выводим сообщение об ошибке
                                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                                        }
                                        else
                                        {
                                            // Если символ после "+" не "i", все в порядке
                                            TComp comp1 = new TComp(label1.Text);
                                            TComp comp2 = new TComp(label2.Text);

                                            // Addition
                                            TANumber diff = comp1.Subtract(comp2);
                                            MessageBox.Show($"Subtraction: {comp1} - {comp2} = {diff}");



                                        }
                                    }
                                    else
                                    {
                                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                                    }
                                }
                                else
                                {
                                    // Если строка пуста, выводим сообщение об ошибке
                                    MessageBox.Show("Строка пуста.");
                                }
                            }
                            else
                            {
                                // Если строка пуста, выводим сообщение об ошибке
                                Console.WriteLine("Ошибка: Строка пуста.");
                            }
                        }
                    }
                    else
                    {
                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                    }
                }
                else
                {
                    // Если строка пуста, выводим сообщение об ошибке
                    MessageBox.Show("Строка пуста.");
                }
            }
            else
            {
                // Если строка пуста, выводим сообщение об ошибке
                Console.WriteLine("Ошибка: Строка пуста.");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, что строка не пуста
            if (!string.IsNullOrEmpty(text))
            {
                // Проверяем, что строка не пуста
                if (!string.IsNullOrEmpty(text))
                {
                    // Находим индекс знака "+"
                    int indexOfPlus = text.IndexOf("+");

                    // Проверяем, что знак "+" найден и не является последним символом в строке
                    if (indexOfPlus != -1 && indexOfPlus < text.Length - 1)
                    {
                        // Получаем символ, следующий за знаком "+"
                        char nextChar = text[indexOfPlus + 1];

                        // Проверяем, является ли этот символ "i"
                        if (nextChar == 'i')
                        {
                            // Если символ после "+" - "i", выводим сообщение об ошибке
                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                        }
                        else
                        {
                            // Если символ после "+" не "i", все в порядке
                            string text2 = label2.Text;

                            // Проверяем, что строка не пуста
                            if (!string.IsNullOrEmpty(text))
                            {

                                // Проверяем, что строка не пуста
                                if (!string.IsNullOrEmpty(text))
                                {
                                    // Находим индекс знака "+"
                                    int indexOfPlus2 = text.IndexOf("+");

                                    // Проверяем, что знак "+" найден и не является последним символом в строке
                                    if (indexOfPlus2 != -1 && indexOfPlus2 < text.Length - 1)
                                    {
                                        // Получаем символ, следующий за знаком "+"
                                        char nextChar2 = text[indexOfPlus2 + 1];

                                        // Проверяем, является ли этот символ "i"
                                        if (nextChar2 == 'i')
                                        {
                                            // Если символ после "+" - "i", выводим сообщение об ошибке
                                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                                        }
                                        else
                                        {
                                            // Если символ после "+" не "i", все в порядке
                                            TComp comp1 = new TComp(label1.Text);
                                            TComp comp2 = new TComp(label2.Text);

                                            // Addition
                                            TANumber quotient = comp1.Divide(comp2);
                                            MessageBox.Show($"Division: {comp1} / {comp2} = {quotient}");



                                        }
                                    }
                                    else
                                    {
                                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                                    }
                                }
                                else
                                {
                                    // Если строка пуста, выводим сообщение об ошибке
                                    MessageBox.Show("Строка пуста.");
                                }
                            }
                            else
                            {
                                // Если строка пуста, выводим сообщение об ошибке
                                Console.WriteLine("Ошибка: Строка пуста.");
                            }
                        }
                    }
                    else
                    {
                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                    }
                }
                else
                {
                    // Если строка пуста, выводим сообщение об ошибке
                    MessageBox.Show("Строка пуста.");
                }
            }
            else
            {
                // Если строка пуста, выводим сообщение об ошибке
                Console.WriteLine("Ошибка: Строка пуста.");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string text = label1.Text;

            // Проверяем, что строка не пуста
            if (!string.IsNullOrEmpty(text))
            {
                // Проверяем, что строка не пуста
                if (!string.IsNullOrEmpty(text))
                {
                    // Находим индекс знака "+"
                    int indexOfPlus = text.IndexOf("+");

                    // Проверяем, что знак "+" найден и не является последним символом в строке
                    if (indexOfPlus != -1 && indexOfPlus < text.Length - 1)
                    {
                        // Получаем символ, следующий за знаком "+"
                        char nextChar = text[indexOfPlus + 1];

                        // Проверяем, является ли этот символ "i"
                        if (nextChar == 'i')
                        {
                            // Если символ после "+" - "i", выводим сообщение об ошибке
                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                        }
                        else
                        {
                            // Если символ после "+" не "i", все в порядке
                            string text2 = label2.Text;

                            // Проверяем, что строка не пуста
                            if (!string.IsNullOrEmpty(text))
                            {

                                // Проверяем, что строка не пуста
                                if (!string.IsNullOrEmpty(text))
                                {
                                    // Находим индекс знака "+"
                                    int indexOfPlus2 = text.IndexOf("+");

                                    // Проверяем, что знак "+" найден и не является последним символом в строке
                                    if (indexOfPlus2 != -1 && indexOfPlus2 < text.Length - 1)
                                    {
                                        // Получаем символ, следующий за знаком "+"
                                        char nextChar2 = text[indexOfPlus2 + 1];

                                        // Проверяем, является ли этот символ "i"
                                        if (nextChar2 == 'i')
                                        {
                                            // Если символ после "+" - "i", выводим сообщение об ошибке
                                            MessageBox.Show("После знака '+' не должен следовать символ 'i'");
                                        }
                                        else
                                        {
                                            // Если символ после "+" не "i", все в порядке
                                            TComp comp1 = new TComp(label1.Text);
                                            TComp comp2 = new TComp(label2.Text);

                                            // Addition
                                            TANumber product = comp1.Multiply(comp2);
                                            MessageBox.Show($"Multiplication: {comp1} * {comp2} = {product}");



                                        }
                                    }
                                    else
                                    {
                                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                                    }
                                }
                                else
                                {
                                    // Если строка пуста, выводим сообщение об ошибке
                                    MessageBox.Show("Строка пуста.");
                                }
                            }
                            else
                            {
                                // Если строка пуста, выводим сообщение об ошибке
                                Console.WriteLine("Ошибка: Строка пуста.");
                            }
                        }
                    }
                    else
                    {
                        // Если знак "+" не найден или является последним символом, выводим сообщение об ошибке
                        MessageBox.Show("Знак '+' не найден или находится в конце строки.");
                    }
                }
                else
                {
                    // Если строка пуста, выводим сообщение об ошибке
                    MessageBox.Show("Строка пуста.");
                }
            }
            else
            {
                // Если строка пуста, выводим сообщение об ошибке
                Console.WriteLine("Ошибка: Строка пуста.");
            }
        }
    }
}



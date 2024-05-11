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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace universalCalculate
{
    public partial class drobi : Form
    {
        TMemory memory = new TMemory();

        public drobi()
        {
            InitializeComponent();
        }

        private void BtnNumberClicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            // this.label1.Text = button.Text;
            if (label1.Text == "0")
                label1.Text = button.Text;
            else
                label1.Text += button.Text;
        }

        public string Parcing(string textBoxContent)
        {
            // Разделение строки по символам операции
            string[] parts = textBoxContent.Split(new char[] { '+', '-', '/', '*' });

            TFrac fraction1 = new TFrac(0, 1);
            TFrac fraction2 = new TFrac(0, 1);
            TFrac result = new TFrac(0, 1);


            int i = 0;
            foreach (string part in parts)
            {
                // Разделение каждой части на числитель и знаменатель по символу '|'
                string[] fractionParts = part.Split('|');

                if (fractionParts.Length == 2)
                {
                    if (i == 0)
                    {
                        fraction1 = new TFrac(int.Parse(fractionParts[0]), int.Parse(fractionParts[1]));
                    }
                    else if (i == 1)
                    {
                        fraction2 = new TFrac(int.Parse(fractionParts[0]), int.Parse(fractionParts[1]));
                    }
                    i++;
                }
                else
                {
                    MessageBox.Show("Некорректный формат дроби. Ожидается 'числитель|знаменатель'");
                }
            }

            // Выполнение операции в зависимости от наличия символов операции в строке
            if (textBoxContent.Contains("+"))
            {
                result = (TFrac)fraction1.Add(fraction2);

            }
            else if (textBoxContent.Contains("-"))
            {
                result = (TFrac)fraction1.Subtract(fraction2);
            }
            else if (textBoxContent.Contains("*"))
            {
                result = (TFrac)fraction1.Multiply(fraction2);
            }
            else if (textBoxContent.Contains("/"))
            {
                result = (TFrac)fraction1.Divide(fraction2);
            }

            // Преобразование числителя и знаменателя результата в строку и объединение их через символ '|'

            string resultString = result.ToString();
            return resultString;
        }







        private void button18_Click(object sender, EventArgs e)//отнять в памяти
        {
            string text = label1.Text;
            TFrac fraction1 = new TFrac(0, 1);
            TFrac fraction2 = new TFrac(0, 1);
            TFrac result = new TFrac(0, 1);

            // Подсчитываем количество символов '|'
            int count = 0;
            foreach (char c in text)
            {
                if (c == '|')
                {
                    count++;
                }
            }

            // Проверяем наличие ровно одного символа '|'
            if (count == 1)
            {
                int index = label1.Text.IndexOf('|');
                if (index != -1 && index + 1 < label1.Text.Length && label1.Text[index + 1] == '0')
                {
                    MessageBox.Show("Деление на 0 недопустимо");
                }
                else
                {
                    string textBoxContent = label1.Text;
                    if (textBoxContent.Contains("+") || textBoxContent.Contains("-") || textBoxContent.Contains("*") || textBoxContent.Contains("/"))
                    {
                        MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
                    }
                    else
                    {
                        // Выполняем вычитание
                        string[] fractionParts = textBoxContent.Split('|'); // Разделяем на числитель и знаменатель
                        fraction1 = new TFrac(int.Parse(fractionParts[0]), int.Parse(fractionParts[1]));
                        string textBoxContent2 = labelMemory.Text;
                        string[] fractionParts2 = textBoxContent2.Split('|');
                        fraction2 = new TFrac(int.Parse(fractionParts2[0]), int.Parse(fractionParts2[1]));
                        result = (TFrac)fraction2.Subtract(fraction1);

                        // Приводим результат к виду числитель|знаменатель
                        //string resultString = memory.Numerator.ToString() + "|" + memory.Denominator.ToString();
                        labelMemory.Text = result.ToString().Replace("/", "|");
                    }
                }

            }
            else
            {
                MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button14.Text;
            else
                label1.Text += button14.Text;
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

        private void button12_Click(object sender, EventArgs e)//+
        {
            string text = label1.Text;
            int index = text.IndexOf("|");
            int index2 = text.IndexOf("/");

            if ((index != -1 && index + 1 < text.Length && text[index + 1] == '0') ||
                (index2 != -1 && index2 + 1 < text.Length && text[index2 + 1] == '0'))
            {
                MessageBox.Show("Деление на ноль невозможно");
            }
            else
            {
                string textBoxContent = label1.Text;
                if (textBoxContent.Substring(1).Contains("+") || textBoxContent.Substring(1).Contains("-") ||
                    textBoxContent.Substring(1).Contains("*") || textBoxContent.Substring(1).Contains("/"))
                {
                    string resultString = Parcing(textBoxContent);
                    resultString = resultString.Replace("/", "|");
                    label1.Text = resultString + "+";
                }
                else
                {
                    label1.Text += "+";
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)//-
        {
            string text = label1.Text;
            int index = text.IndexOf("|");
            int index2 = text.IndexOf("/");

            if ((index != -1 && index + 1 < text.Length && text[index + 1] == '0') ||
                (index2 != -1 && index2 + 1 < text.Length && text[index2 + 1] == '0'))
            {
                MessageBox.Show("Деление на ноль невозможно");
            }
            else
            {
                string textBoxContent = label1.Text;
                if (textBoxContent.Substring(1).Contains("+") || textBoxContent.Substring(1).Contains("-") ||
                    textBoxContent.Substring(1).Contains("*") || textBoxContent.Substring(1).Contains("/"))
                {
                    string resultString = Parcing(textBoxContent);
                    resultString = resultString.Replace("/", "|");
                    label1.Text = resultString + "-";
                }
                else
                {
                    label1.Text += "-";
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)//*
        {
            string text = label1.Text;
            int index = text.IndexOf("|");
            int index2 = text.IndexOf("/");

            if ((index != -1 && index + 1 < text.Length && text[index + 1] == '0') ||
                (index2 != -1 && index2 + 1 < text.Length && text[index2 + 1] == '0'))
            {
                MessageBox.Show("Деление на ноль невозможно");
            }
            else
            {
                string textBoxContent = label1.Text;
                if (textBoxContent.Substring(1).Contains("+") || textBoxContent.Substring(1).Contains("-") ||
                    textBoxContent.Substring(1).Contains("*") || textBoxContent.Substring(1).Contains("/"))
                {
                    string resultString = Parcing(textBoxContent);
                    resultString = resultString.Replace("/", "|");
                    label1.Text = resultString + "*";
                }
                else
                {
                    label1.Text += "*";
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)// :
        {
            string text = label1.Text;
            int index = text.IndexOf("|");
            int index2 = text.IndexOf("/");

            if ((index != -1 && index + 1 < text.Length && text[index + 1] == '0') ||
                (index2 != -1 && index2 + 1 < text.Length && text[index2 + 1] == '0'))
            {
                MessageBox.Show("Деление на ноль невозможно");
            }
            else
            {
                string textBoxContent = label1.Text;
                if (textBoxContent.Substring(1).Contains("+") || textBoxContent.Substring(1).Contains("-") ||
                    textBoxContent.Substring(1).Contains("*") || textBoxContent.Substring(1).Contains("/"))
                {
                    string resultString = Parcing(textBoxContent);
                    resultString = resultString.Replace("/", "|");
                    label1.Text = resultString + "/";
                }
                else
                {
                    label1.Text += "/";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)//=
        {
            string text = label1.Text;
            int index = text.IndexOf("|");
            int index2 = text.IndexOf("/");

            if ((index != -1 && index + 1 < text.Length && text[index + 1] == '0') ||
                (index2 != -1 && index2 + 1 < text.Length && text[index2 + 1] == '0'))
            {
                MessageBox.Show("Деление на ноль невозможно");
            }
            else
            {
                string textBoxContent = label1.Text;
                if (textBoxContent.Substring(1).Contains("+") || textBoxContent.Substring(1).Contains("-") ||
                    textBoxContent.Substring(1).Contains("*") || textBoxContent.Substring(1).Contains("/"))
                {
                    string resultString = Parcing(textBoxContent);
                    resultString = resultString.Replace("/", "|");
                    label1.Text = resultString;
                }
                else
                {
                    MessageBox.Show("Введите выражение полностью");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)// точка
        {
            button15.Enabled = false; // Заблокировать кнопку
            MessageBox.Show("Кнопка заблокирована до следующей версии калькулятора!");

        }

        private void button26_Click(object sender, EventArgs e)// стереть 
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }

        }

        private void button13_Click(object sender, EventArgs e)// плюс минус
        {
            if (label1.Text.Contains("+"))
            {
                label1.Text = label1.Text.Replace("+", "-");
            }
            else if (label1.Text.Contains("-"))
            {
                label1.Text = label1.Text.Replace("-", "+");
            }

        }

        private void button27_Click(object sender, EventArgs e)//CE
        {
            string text = label1.Text;

            // Находим индекс последнего оператора (+, -, *, /) в строке, начиная с конца
            int lastOperatorIndex = -1;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
                {
                    lastOperatorIndex = i;
                    break;
                }
            }

            // Обрезаем текст в текстовом поле до последнего оператора включительно, если оператор найден
            if (lastOperatorIndex != -1)
            {
                label1.Text = text.Substring(0, lastOperatorIndex + 1);
            }

            // Удаляем последний символ, если текстовое поле не пустое после обрезки, чтобы удалить последний оператор из строки
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }

        }

        private void button28_Click(object sender, EventArgs e)//C
        {
            label1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)//символ дроби
        {
            label1.Text += button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false; // Заблокировать кнопку
            MessageBox.Show("Кнопка заблокирована до следующей версии калькулятора!");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false; // Заблокировать кнопку
            MessageBox.Show("Кнопка заблокирована до следующей версии калькулятора!");
        }

        private void button29_Click(object sender, EventArgs e)//вставить в память
        {
            // Подсчитываем количество символов '|'
            int count = 0;
            string text = label1.Text;
            foreach (char c in text)
            {
                if (c == '|')
                {
                    count++;
                }
            }

            // Проверяем наличие ровно одного символа '|'
            if (count == 1)
            {
                int index = label1.Text.IndexOf('|');
                if (index != -1 && index + 1 < label1.Text.Length && label1.Text[index + 1] == '0')
                {
                    MessageBox.Show("Деление на 0 недопустимо");
                }
                else
                {
                    string textBoxContent = label1.Text;
                    if (textBoxContent.Contains("+") || textBoxContent.Contains("-") || textBoxContent.Contains("*") || textBoxContent.Contains("/"))
                    {
                        MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
                    }
                    else
                    {
                        string[] fractionParts = textBoxContent.Split('|');
                        TFrac number = new TFrac(int.Parse(fractionParts[0]), int.Parse(fractionParts[1]));
                        memory.Store(number);
                        TANumber recalledNumber = memory.Recall();
                        labelMemory.Text = recalledNumber.ToString().Replace("/", "|");
                    }
                }

            }
            else
            {
                MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
            }

        }

        private void button25_Click(object sender, EventArgs e)// отчистить память
        {
            memory.Clear();
            TANumber recalledNumber = memory.Recall();
            labelMemory.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)//вставить из памяти
        {
            if (labelMemory.Text == "0")
            {
                MessageBox.Show("Память не должна быть пустой");
            }
            else
            {
                label1.Text += labelMemory.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)//прибавить в памяти
        {
            string text = label1.Text;
            TFrac fraction1 = new TFrac(0, 1);
            TFrac fraction2 = new TFrac(0, 1);
            TFrac result = new TFrac(0, 1);

            // Подсчитываем количество символов '|'
            int count = 0;
            foreach (char c in text)
            {
                if (c == '|')
                {
                    count++;
                }
            }

            // Проверяем наличие ровно одного символа '|'
            if (count == 1)
            {
                int index = label1.Text.IndexOf('|');
                if (index != -1 && index + 1 < label1.Text.Length && label1.Text[index + 1] == '0')
                {
                    MessageBox.Show("Деление на 0 недопустимо");
                }
                else
                {
                    string textBoxContent = label1.Text;
                    if (textBoxContent.Contains("+") || textBoxContent.Contains("-") || textBoxContent.Contains("*") || textBoxContent.Contains("/"))
                    {
                        MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
                    }
                    else
                    {
                        // Выполняем вычитание
                        string[] fractionParts = textBoxContent.Split('|'); // Разделяем на числитель и знаменатель
                        fraction1 = new TFrac(int.Parse(fractionParts[0]), int.Parse(fractionParts[1]));
                        string textBoxContent2 = labelMemory.Text;
                        string[] fractionParts2 = textBoxContent2.Split('|');
                        fraction2 = new TFrac(int.Parse(fractionParts2[0]), int.Parse(fractionParts2[1]));
                        result = (TFrac)fraction2.Add(fraction1);

                        // Приводим результат к виду числитель|знаменатель
                        //string resultString = memory.Numerator.ToString() + "|" + memory.Denominator.ToString();
                        labelMemory.Text = result.ToString().Replace("/", "|");
                    }
                }

            }
            else
            {
                MessageBox.Show("Должна быть операция: число|число для выполнения операции вычитания");
            }
        }
    }
}


//обработка что бы на 0 не делилась дробь
// при знаках + - / * = мы разбиваем дробь по знаку | и знаку + - / * что бы получить четыре числа 2 числителя и 2 знаменателя

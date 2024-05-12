using System;
using System.Windows.Forms;

namespace universalCalculate
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            static void TestTMemory()
            {
                Console.WriteLine("Testing TMemory...");
                try
                {
                    TMemory memory = new TMemory();

                    // Storing and recalling a number
                    TFrac number = new TFrac(1, 2);
                    memory.Store(number);
                    TANumber recalledNumber = memory.Recall();
                    Console.WriteLine($"Recalled number: {recalledNumber}");

                    // Clearing memory
                    memory.Clear();
                    recalledNumber = memory.Recall(); // Should throw exception
                    Console.WriteLine($"Recalled number after clearing: {recalledNumber}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
                Console.WriteLine();
            }

        }


        static void TestTPNumber()
        {
            Console.WriteLine("Testing TPNumber...");
            try
            {
                TPNumber number1 = new TPNumber("10", 10);
                TPNumber number2 = new TPNumber("20", 10);

                // Addition
                TANumber sum = number1.Add(number2);
                Console.WriteLine($"Addition: {number1} + {number2} = {sum}");

                // Subtraction
                TANumber diff = number1.Subtract(number2);
                Console.WriteLine($"Subtraction: {number1} - {number2} = {diff}");

                // Multiplication
                TANumber product = number1.Multiply(number2);
                Console.WriteLine($"Multiplication: {number1} * {number2} = {product}");

                // Division
                TANumber quotient = number1.Divide(number2);
                Console.WriteLine($"Division: {number1} / {number2} = {quotient}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTFrac()
        {
            Console.WriteLine("Testing TFrac...");
            try
            {
                TFrac frac1 = new TFrac(1, 2);
                TFrac frac2 = new TFrac(1, 4);

                // Addition
                TANumber sum = frac1.Add(frac2);
                Console.WriteLine($"Addition: {frac1} + {frac2} = {sum}");

                // Subtraction
                TANumber diff = frac1.Subtract(frac2);
                Console.WriteLine($"Subtraction: {frac1} - {frac2} = {diff}");

                // Multiplication
                TANumber product = frac1.Multiply(frac2);
                Console.WriteLine($"Multiplication: {frac1} * {frac2} = {product}");

                // Division
                TANumber quotient = frac1.Divide(frac2);
                Console.WriteLine($"Division: {frac1} / {frac2} = {quotient}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTComp()
        {
            Console.WriteLine("Testing TComp...");
            try
            {
                TComp comp1 = new TComp(1, 2);
                TComp comp2 = new TComp(2, 3);

                // Addition
                TANumber sum = comp1.Add(comp2);
                Console.WriteLine($"Addition: {comp1} + {comp2} = {sum}");

                // Subtraction
                TANumber diff = comp1.Subtract(comp2);
                Console.WriteLine($"Subtraction: {comp1} - {comp2} = {diff}");

                // Multiplication
                TANumber product = comp1.Multiply(comp2);
                Console.WriteLine($"Multiplication: {comp1} * {comp2} = {product}");

                // Division
                TANumber quotient = comp1.Divide(comp2);
                Console.WriteLine($"Division: {comp1} / {comp2} = {quotient}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTMemory()
        {
            Console.WriteLine("Testing TMemory...");
            try
            {
                TMemory memory = new TMemory();

                // Storing and recalling a number
                TPNumber number = new TPNumber("10", 10);
                memory.Store(number);
                TANumber recalledNumber = memory.Recall();
                Console.WriteLine($"Recalled number: {recalledNumber}");

                // Clearing memory
                memory.Clear();
                recalledNumber = memory.Recall(); // Should throw exception
                Console.WriteLine($"Recalled number after clearing: {recalledNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTREditor()
        {
            Console.WriteLine("Testing TREditor...");
            try
            {
                TREditor editor = new TREditor();

                // Setting and getting a number
                TPNumber number = new TPNumber("123", 10);
                editor.SetNumber(number);
                TANumber retrievedNumber = editor.GetNumber();
                Console.WriteLine($"Retrieved number: {retrievedNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTFEditor()
        {
            Console.WriteLine("Testing TFEditor...");
            try
            {
                TFEditor editor = new TFEditor();

                // Setting and getting a fraction
                TFrac fraction = new TFrac(3, 4);
                editor.SetNumber(fraction);
                TANumber retrievedFraction = editor.GetNumber();
                Console.WriteLine($"Retrieved fraction: {retrievedFraction}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

        static void TestTCEditor()
        {
            Console.WriteLine("Testing TCEditor...");
            try
            {
                TCEditor editor = new TCEditor();

                // Setting and getting a complex number
                TComp complexNumber = new TComp(2, 3);
                editor.SetNumber(complexNumber);
                TANumber retrievedComplex = editor.GetNumber();
                Console.WriteLine($"Retrieved complex number: {retrievedComplex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.WriteLine();
        }

    }


    public abstract class TANumber
    {
        // Определение абстрактных методов для основных арифметических операций.
        public abstract TANumber Add(TANumber other);
        public abstract TANumber Subtract(TANumber other);
        public abstract TANumber Multiply(TANumber other);
        public abstract TANumber Divide(TANumber other);
    }

    // Реализация класса для действительных чисел в различных системах счисления.
    public class TPNumber : TANumber
    {
        private int number;      // Хранение числа в десятичной системе счисления.
        private int systemBase;  // Основание системы счисления числа.

        // Конструктор принимает строку числа и его систему счисления, конвертирует в int.
        public TPNumber(string number, int systemBase)
        {
            this.number = Convert.ToInt32(number, systemBase);
            this.systemBase = systemBase;
        }
        public int GetSystemBase()
        {
            return systemBase;
        }
        public string GetNumberAsString()
        {
            return Convert.ToString(number, systemBase);
        }

        // Сложение двух чисел того же типа, результат в их системе счисления.
        public override TANumber Add(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int sum = this.number + otherPNumber.number;
                return new TPNumber(Convert.ToString(sum, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("Невозможно складывать различные типы чисел");
        }

        // Вычитание чисел, результат в их системе счисления.
        public override TANumber Subtract(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int diff = this.number - otherPNumber.number;
                return new TPNumber(Convert.ToString(diff, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("Невозможно вычитать различные типы чисел");
        }

        // Умножение чисел, результат в их системе счисления.
        public override TANumber Multiply(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int product = this.number * otherPNumber.number;
                return new TPNumber(Convert.ToString(product, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("Невозможно умножать различные типы чисел");
        }

        // Деление чисел, обработка деления на ноль, результат в их системе счисления.
        public override TANumber Divide(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                if (otherPNumber.number == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                int quotient = this.number / otherPNumber.number;
                return new TPNumber(Convert.ToString(quotient, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("Невозможно делить различные типы чисел");
        }

        // Предоставление строкового представления числа в его системе счисления.
        public override string ToString()
        {
            return Convert.ToString(number, systemBase);
        }
    }

    // Класс для представления простых дробей, поддерживающий автоматическое сокращение.
    public class TFrac : TANumber
    {
        private int numerator;   // Числитель дроби.
        private int denominator; // Знаменатель дроби.

        // Конструктор инициализирует дробь и сокращает ее.
        public TFrac(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю");
            }
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
        }

        // Метод для вычисления наибольшего общего делителя.
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод сокращения дроби.
        private void Reduce()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        // Реализация арифметических операций с учетом сокращения результата.
        public override TANumber Add(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newDenominator = this.denominator * otherFrac.denominator;
                int newNumerator = this.numerator * otherFrac.denominator + otherFrac.numerator * this.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("Невозможно складывать различные типы чисел");
        }

        public override TANumber Subtract(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newDenominator = this.denominator * otherFrac.denominator;
                int newNumerator = this.numerator * otherFrac.denominator - otherFrac.numerator * this.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("Невозможно вычитать различные типы чисел");
        }

        public override TANumber Multiply(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newNumerator = this.numerator * otherFrac.numerator;
                int newDenominator = this.denominator * otherFrac.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("Невозможно умножать различные типы чисел");
        }

        public override TANumber Divide(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                if (otherFrac.numerator == 0)
                {
                    throw new DivideByZeroException("Невозможно делить на ноль");
                }
                int newNumerator = this.numerator * otherFrac.denominator;
                int newDenominator = this.denominator * otherFrac.numerator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("Невозможно делить различные типы чисел");
        }

        // Предоставление строкового представления дроби.
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }


    // Класс для представления комплексных чисел.
    public class TComp : TANumber
    {
        private double real;      // Действительная часть комплексного числа.
        private double imaginary; // Мнимая часть комплексного числа.

        // Конструктор для прямой инициализации комплексного числа.
        public TComp(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Конструктор, который парсит комплексное число из строки.
        public TComp(string number)
        {
            string[] parts = number.Split('+', StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                string cleanedPart = part.Trim();
                if (cleanedPart.EndsWith("i"))
                {
                    // Парсинг мнимой части
                    imaginary += double.Parse(cleanedPart.Replace("i", ""));
                }
                else
                {
                    // Парсинг действительной части
                    real += double.Parse(cleanedPart);
                }
            }
        }

        // Реализация сложения для комплексных чисел.
        public override TANumber Add(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real + otherComp.real;
                double newImaginary = this.imaginary + otherComp.imaginary;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("Невозможно складывать различные типы чисел");
        }

        // Реализация вычитания для комплексных чисел.
        public override TANumber Subtract(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real - otherComp.real;
                double newImaginary = this.imaginary - otherComp.imaginary;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("Невозможно вычитать различные типы чисел");
        }

        // Реализация умножения для комплексных чисел.
        public override TANumber Multiply(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real * otherComp.real - this.imaginary * otherComp.imaginary;
                double newImaginary = this.real * otherComp.imaginary + this.imaginary * otherComp.real;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("Невозможно умножать различные типы чисел");
        }

        // Реализация деления для комплексных чисел.
        public override TANumber Divide(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double divisor = otherComp.real * otherComp.real + otherComp.imaginary * otherComp.imaginary;
                if (divisor == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                double newReal = (this.real * otherComp.real + this.imaginary * otherComp.imaginary) / divisor;
                double newImaginary = (this.imaginary * otherComp.real - this.real * otherComp.imaginary) / divisor;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("Невозможно делить различные типы чисел");
        }

        // Возвращает строковое представление комплексного числа.
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }


    // Абстрактный тип данных для памяти
    public class TMemory
    {
        // Хранение числа типа TANumber
        private TANumber storedNumber;

        // Метод для сохранения числа в памяти.
        public void Store(TANumber number)
        {
            storedNumber = number;
        }

        // Метод для извлечения числа из памяти.
        public TANumber Recall()
        {
            return storedNumber;
        }

        // Метод для очистки памяти.
        public void Clear()
        {
            storedNumber = null;
        }
    }


    // Абстрактный тип данных для процессора
    public abstract class TProc
    {
        // Методы для обработки чисел
        public abstract TANumber Process(TANumber number);
    }

    // Абстрактный класс редактора чисел, определяющий интерфейс для взаимодействия с числами.
    public abstract class TAEditor
    {
        // Метод для установки числа.
        public abstract void SetNumber(TANumber number);
        // Метод для получения числа.
        public abstract TANumber GetNumber();
        // Метод для сохранения числа в памяти редактора.
        public abstract void SaveToMemory(TMemory memory);
        // Метод для загрузки числа из памяти редактора.
        public abstract void LoadFromMemory(TMemory memory);
    }

    // Редактор для действительных чисел, управляет числами TPNumber.
    public class TREditor : TAEditor
    {
        private TPNumber number; // Хранение числа в редакторе.

        // Установка числа, если оно соответствует типу TPNumber.
        public override void SetNumber(TANumber number)
        {
            if (number is TPNumber)
            {
                this.number = (TPNumber)number;
            }
            else
            {
                throw new ArgumentException("Невозможно установить номер типа не-TPNumber в TREditor");
            }
        }

        // Получение установленного числа.
        public override TANumber GetNumber()
        {
            return number;
        }

        // Сохранение числа в памяти редактора.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // Загрузка числа из памяти редактора.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TPNumber)memory.Recall();
        }
    }

    // Редактор для дробей, управляет числами TFrac.
    public class TFEditor : TAEditor
    {
        private TFrac number; // Хранение дроби в редакторе.

        // Установка дроби, если она соответствует типу TFrac.
        public override void SetNumber(TANumber number)
        {
            if (number is TFrac)
            {
                this.number = (TFrac)number;
            }
            else
            {
                throw new ArgumentException("Невозможно установить номер типа, отличного от TFrac, в TFEditor");
            }
        }

        // Получение установленной дроби.
        public override TANumber GetNumber()
        {
            return number;
        }

        // Сохранение числа в памяти редактора.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // Загрузка числа из памяти редактора.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TFrac)memory.Recall();
        }
    }

    // Редактор для комплексных чисел, управляет числами TComp.
    public class TCEditor : TAEditor
    {
        private TComp number; // Хранение комплексного числа в редакторе.

        // Установка комплексного числа, если оно соответствует типу TComp.
        public override void SetNumber(TANumber number)
        {
            if (number is TComp)
            {
                this.number = (TComp)number;
            }
            else
            {
                throw new ArgumentException("Невозможно установить номер типа, не относящегося к TComp, в TCEditor");
            }
        }

        // Получение установленного комплексного числа.
        public override TANumber GetNumber()
        {
            return number;
        }

        // Сохранение числа в памяти редактора.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // Загрузка числа из памяти редактора.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TComp)memory.Recall();
        }
    }





}

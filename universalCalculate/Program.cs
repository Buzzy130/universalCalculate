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
        // ����������� ����������� ������� ��� �������� �������������� ��������.
        public abstract TANumber Add(TANumber other);
        public abstract TANumber Subtract(TANumber other);
        public abstract TANumber Multiply(TANumber other);
        public abstract TANumber Divide(TANumber other);
    }

    // ���������� ������ ��� �������������� ����� � ��������� �������� ���������.
    public class TPNumber : TANumber
    {
        private int number;      // �������� ����� � ���������� ������� ���������.
        private int systemBase;  // ��������� ������� ��������� �����.

        // ����������� ��������� ������ ����� � ��� ������� ���������, ������������ � int.
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

        // �������� ���� ����� ���� �� ����, ��������� � �� ������� ���������.
        public override TANumber Add(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int sum = this.number + otherPNumber.number;
                return new TPNumber(Convert.ToString(sum, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("���������� ���������� ��������� ���� �����");
        }

        // ��������� �����, ��������� � �� ������� ���������.
        public override TANumber Subtract(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int diff = this.number - otherPNumber.number;
                return new TPNumber(Convert.ToString(diff, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        // ��������� �����, ��������� � �� ������� ���������.
        public override TANumber Multiply(TANumber other)
        {
            if (other is TPNumber otherPNumber)
            {
                int product = this.number * otherPNumber.number;
                return new TPNumber(Convert.ToString(product, this.systemBase), this.systemBase);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        // ������� �����, ��������� ������� �� ����, ��������� � �� ������� ���������.
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
            throw new ArgumentException("���������� ������ ��������� ���� �����");
        }

        // �������������� ���������� ������������� ����� � ��� ������� ���������.
        public override string ToString()
        {
            return Convert.ToString(number, systemBase);
        }
    }

    // ����� ��� ������������� ������� ������, �������������� �������������� ����������.
    public class TFrac : TANumber
    {
        private int numerator;   // ��������� �����.
        private int denominator; // ����������� �����.

        // ����������� �������������� ����� � ��������� ��.
        public TFrac(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("����������� �� ����� ���� ����� ����");
            }
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
        }

        // ����� ��� ���������� ����������� ������ ��������.
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

        // ����� ���������� �����.
        private void Reduce()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        // ���������� �������������� �������� � ������ ���������� ����������.
        public override TANumber Add(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newDenominator = this.denominator * otherFrac.denominator;
                int newNumerator = this.numerator * otherFrac.denominator + otherFrac.numerator * this.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("���������� ���������� ��������� ���� �����");
        }

        public override TANumber Subtract(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newDenominator = this.denominator * otherFrac.denominator;
                int newNumerator = this.numerator * otherFrac.denominator - otherFrac.numerator * this.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        public override TANumber Multiply(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                int newNumerator = this.numerator * otherFrac.numerator;
                int newDenominator = this.denominator * otherFrac.denominator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        public override TANumber Divide(TANumber other)
        {
            if (other is TFrac otherFrac)
            {
                if (otherFrac.numerator == 0)
                {
                    throw new DivideByZeroException("���������� ������ �� ����");
                }
                int newNumerator = this.numerator * otherFrac.denominator;
                int newDenominator = this.denominator * otherFrac.numerator;
                return new TFrac(newNumerator, newDenominator);
            }
            throw new ArgumentException("���������� ������ ��������� ���� �����");
        }

        // �������������� ���������� ������������� �����.
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }


    // ����� ��� ������������� ����������� �����.
    public class TComp : TANumber
    {
        private double real;      // �������������� ����� ������������ �����.
        private double imaginary; // ������ ����� ������������ �����.

        // ����������� ��� ������ ������������� ������������ �����.
        public TComp(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // �����������, ������� ������ ����������� ����� �� ������.
        public TComp(string number)
        {
            string[] parts = number.Split('+', StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                string cleanedPart = part.Trim();
                if (cleanedPart.EndsWith("i"))
                {
                    // ������� ������ �����
                    imaginary += double.Parse(cleanedPart.Replace("i", ""));
                }
                else
                {
                    // ������� �������������� �����
                    real += double.Parse(cleanedPart);
                }
            }
        }

        // ���������� �������� ��� ����������� �����.
        public override TANumber Add(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real + otherComp.real;
                double newImaginary = this.imaginary + otherComp.imaginary;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("���������� ���������� ��������� ���� �����");
        }

        // ���������� ��������� ��� ����������� �����.
        public override TANumber Subtract(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real - otherComp.real;
                double newImaginary = this.imaginary - otherComp.imaginary;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        // ���������� ��������� ��� ����������� �����.
        public override TANumber Multiply(TANumber other)
        {
            if (other is TComp otherComp)
            {
                double newReal = this.real * otherComp.real - this.imaginary * otherComp.imaginary;
                double newImaginary = this.real * otherComp.imaginary + this.imaginary * otherComp.real;
                return new TComp(newReal, newImaginary);
            }
            throw new ArgumentException("���������� �������� ��������� ���� �����");
        }

        // ���������� ������� ��� ����������� �����.
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
            throw new ArgumentException("���������� ������ ��������� ���� �����");
        }

        // ���������� ��������� ������������� ������������ �����.
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }


    // ����������� ��� ������ ��� ������
    public class TMemory
    {
        // �������� ����� ���� TANumber
        private TANumber storedNumber;

        // ����� ��� ���������� ����� � ������.
        public void Store(TANumber number)
        {
            storedNumber = number;
        }

        // ����� ��� ���������� ����� �� ������.
        public TANumber Recall()
        {
            return storedNumber;
        }

        // ����� ��� ������� ������.
        public void Clear()
        {
            storedNumber = null;
        }
    }


    // ����������� ��� ������ ��� ����������
    public abstract class TProc
    {
        // ������ ��� ��������� �����
        public abstract TANumber Process(TANumber number);
    }

    // ����������� ����� ��������� �����, ������������ ��������� ��� �������������� � �������.
    public abstract class TAEditor
    {
        // ����� ��� ��������� �����.
        public abstract void SetNumber(TANumber number);
        // ����� ��� ��������� �����.
        public abstract TANumber GetNumber();
        // ����� ��� ���������� ����� � ������ ���������.
        public abstract void SaveToMemory(TMemory memory);
        // ����� ��� �������� ����� �� ������ ���������.
        public abstract void LoadFromMemory(TMemory memory);
    }

    // �������� ��� �������������� �����, ��������� ������� TPNumber.
    public class TREditor : TAEditor
    {
        private TPNumber number; // �������� ����� � ���������.

        // ��������� �����, ���� ��� ������������� ���� TPNumber.
        public override void SetNumber(TANumber number)
        {
            if (number is TPNumber)
            {
                this.number = (TPNumber)number;
            }
            else
            {
                throw new ArgumentException("���������� ���������� ����� ���� ��-TPNumber � TREditor");
            }
        }

        // ��������� �������������� �����.
        public override TANumber GetNumber()
        {
            return number;
        }

        // ���������� ����� � ������ ���������.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // �������� ����� �� ������ ���������.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TPNumber)memory.Recall();
        }
    }

    // �������� ��� ������, ��������� ������� TFrac.
    public class TFEditor : TAEditor
    {
        private TFrac number; // �������� ����� � ���������.

        // ��������� �����, ���� ��� ������������� ���� TFrac.
        public override void SetNumber(TANumber number)
        {
            if (number is TFrac)
            {
                this.number = (TFrac)number;
            }
            else
            {
                throw new ArgumentException("���������� ���������� ����� ����, ��������� �� TFrac, � TFEditor");
            }
        }

        // ��������� ������������� �����.
        public override TANumber GetNumber()
        {
            return number;
        }

        // ���������� ����� � ������ ���������.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // �������� ����� �� ������ ���������.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TFrac)memory.Recall();
        }
    }

    // �������� ��� ����������� �����, ��������� ������� TComp.
    public class TCEditor : TAEditor
    {
        private TComp number; // �������� ������������ ����� � ���������.

        // ��������� ������������ �����, ���� ��� ������������� ���� TComp.
        public override void SetNumber(TANumber number)
        {
            if (number is TComp)
            {
                this.number = (TComp)number;
            }
            else
            {
                throw new ArgumentException("���������� ���������� ����� ����, �� ������������ � TComp, � TCEditor");
            }
        }

        // ��������� �������������� ������������ �����.
        public override TANumber GetNumber()
        {
            return number;
        }

        // ���������� ����� � ������ ���������.
        public override void SaveToMemory(TMemory memory)
        {
            memory.Store(number);
        }

        // �������� ����� �� ������ ���������.
        public override void LoadFromMemory(TMemory memory)
        {
            number = (TComp)memory.Recall();
        }
    }





}

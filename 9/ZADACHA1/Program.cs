using System;
using System.Collections.Generic;
using System.Text;

namespace Project9
{
    interface СreatingMatrices
    {
        void Vivod(int c, int d);
    }
    interface CteatePodmtrix
    {
        void ShowArray();
    }
    class Matrix : СreatingMatrices
    {
        private int a, b, c, d;
        public Matrix(int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    matrix[i, j] = r.Next(-100, 100);
        }
        public int[,] matrix = new int[100, 100];

        public void Vivod(int c, int d) //метод вывода матрицы
        {
            //выводим матрицу 
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    class Podmatrix : CteatePodmtrix
    {
        public Podmatrix(ref int[,] matr, int a, int b)
        //в конструктор передаём параметры: указатель на исх. матрицу, длинну ширину создаваемой матрицы
        {
            A = a; B = b;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Array[i, j] = matr[i, j]; //передаём элементы исх. матрицы в подматрицу
        }

        private int A, B; // А,В - размер матрицы
        private int[,] Array = new int[300, 300]; //объявляем матрицу

        public void ShowArray() //метод вывода подматрицы
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write(Array[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
    class Print
    {
        public static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Дана матрица: Martix[a, b]");
            Console.Write("Введите количество строк a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов b = ");
            b = Int32.Parse(Console.ReadLine());
            Matrix rev = new Matrix(a, b);
            rev.Vivod(a, b);

            Console.WriteLine("Выводим на экран подматрицу:");
            Console.WriteLine("Дана матрица: PodMatr[c, d]");
            Console.Write("Введите количество строк подматрицы c = ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы d = ");
            d = Int32.Parse(Console.ReadLine());

            Podmatrix A = new Podmatrix(ref rev.matrix, c, d);
            A.ShowArray();
            Console.ReadKey();

        }
    }
}
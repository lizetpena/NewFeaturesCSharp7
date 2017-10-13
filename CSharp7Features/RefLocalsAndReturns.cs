using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class RefLocalsAndReturns
    {
        public void TestFind(int[,] matrix)
        {
            var indices = Find(matrix, (val) => val == 42);
            Console.WriteLine(indices);
            matrix[indices.i, indices.j] = 24;
        }

        public (int i, int j) Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return (i, j);
            return (-1, -1); // Not found
        }

        public void TestFind3(int[,] matrix)
        {
            var valItem = Find3(matrix, (val) => val == 42);
            Console.WriteLine(valItem);
            valItem = 24;
            Console.WriteLine(matrix[4, 2]);
        }

        public ref int Find3(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }
    }
}

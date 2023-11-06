// Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] numsArr = {2, 4, 5, 1, 3, 6, 3, 2, 5};
            int findNum = 10;
            FindSumParts(numsArr, findNum);
        }
        public static bool FindSumParts(int[] numsArr, int findNum)
        {        
            for (int i = 1; i < numsArr.Length - 1; i++)
            {
                int left = i - 1;
                int right = i + 1;
                int result;

                result = numsArr[left] + numsArr[i] + numsArr[right];
                if (result == findNum)
                {
                    Console.WriteLine($"Искомое число {findNum} состоит из {numsArr[left]} + {numsArr[i]} + {numsArr[right]}");
                    return true;
                }
                else
                {
                    left++;
                    right++;
                }                
            }
            Console.WriteLine("Подходящих чисел не найдено");
            return false;
        }
    }
}
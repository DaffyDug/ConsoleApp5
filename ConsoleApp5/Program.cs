using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            ARRAY(array);
            //MIN_ARRAY(array);
            //MAX_ARRAY(array);
            //SUM_ARRAY(array);
            //int result = SERHC_INDEX(array);
            //Console.WriteLine(result);
            DOUBLE_ARRAY(array);
        }

        static void ARRAY(int[] array)
        {

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
                Console.Write(array[i] + " ");
            }

        }
        static void MIN_ARRAY(int[] array)
        {
            int minValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine("min" + minValue);
        }
        static void MAX_ARRAY(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
        static void SUM_ARRAY(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        static int SERHC_INDEX(int[] array)
        {
            int sum = 0;
            string a = Console.ReadLine();
            int a2 = int.Parse(a);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a2)
                {
                    sum = i;
                    break;
                }
            }
            Console.WriteLine(sum);
            return 0;

        }
        static void DOUBLE_ARRAY(int[] array)
        {
            string a = Console.ReadLine();
            int a2 = int.Parse(a);

            int[] array2 = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array2.Length - 1] = a2;

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i] + ' ');

            }
        }
    }
}
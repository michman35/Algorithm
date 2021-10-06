using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class BinarySearch
	{
        public bool BinarySearchs(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(searchValue == inputArray[mid])
                {
                    return true;
                }
                else if(searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return false;
        }
            public void Array()
            {
                Console.WriteLine("Введите число для двоичного поиска");
                
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                for(int i = 0; i < size; i++)
                {
                    arr[i] = i + 1;
                }
                Console.WriteLine(BinarySearchs(arr, 30));
                Console.ReadKey();
            }
        }

    }


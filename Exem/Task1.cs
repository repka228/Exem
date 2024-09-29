using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exem
{
    public class Task1_class
    {
        private int[]? arr;
        public string Task1_1(int size)
        {
            arr = new int[size];
            StringBuilder answer = new();
            Random random = new();
            for(int i=0;i < size; ++i)
            {
                arr[i] = random.Next(-100,101);
            }
            int count = 0, sum = 0;
            for(int i = 0; i < size; ++i)
            {
                if(i>0)
                {
                    count++;
                    sum += arr[i];
                }
            }
            answer.Append("Кол-во > 0 = " + count.ToString() + " Их сумма = " + sum.ToString());
            return answer.ToString();
        }
        public string Task1_2(int size, int target)
        {
            arr = new int[size];
            StringBuilder answer = new();
            answer.Append("Нечётные элементы меньше " + target.ToString() + ": ");
            Random random = new();
            for (int i = 0; i < size; ++i)
            {
                arr[i] = random.Next(-100,101);
            }
            for (int i = 0; i < size; ++i)
            {
                if (i % 2 != 0 && arr[i]<target)
                {
                    answer.Append(arr[i].ToString() + " ");
                }
            }
            return answer.ToString();
        }
    }
}

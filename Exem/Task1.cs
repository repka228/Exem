using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exem
{
    public class Task1_class:INterfaceTask3
    {
        private int[]? arr;
        int size;
        public string Name => GetType().Name + " " + size.ToString();
        public Task1_class(int size)
        {
            if (size >= 10) { 
                arr = new int[size];
                this.size = size;
            }
            else
            {
                this.size = new Random().Next(10,21);
                arr = new int[this.size];
            }
            Random random = new();
            for (int i = 0; i < size; ++i)
            {
                arr[i] = random.Next(-100, 101);
            }
        }

        public int this[int ind] => arr[ind];

        public string Task1()
        {
            arr = new int[size];
            StringBuilder answer = new();
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
        public string Task1(int target)
        {
            arr = new int[size];
            StringBuilder answer = new();
            answer.Append("Нечётные элементы меньше " + target.ToString() + ": ");
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

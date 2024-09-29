using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exem
{
    public class TaskList : INterfaceTask3
    {
        private readonly List<int>? arr;
        private readonly int allow;
        public TaskList(int size)
        {
            if (size < 10)
                size = new Random().Next(10, 21);
            allow = size;
            Random rnd = new();
            for (int i = 0; i < size; ++i)
            {
                arr?.Add(rnd.Next(-100, 100));
            }
        }

        public int this[int ind] => arr != null ? arr[ind] : -101;

        public string Name => GetType().Name + " " + allow.ToString();
        public string Task1()
        {
            StringBuilder answer = new();
            int count = 0, sum = 0;
            for (int i = 0; i < arr?.Count; ++i)
            {
                if (i > 0)
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
            StringBuilder answer = new();
            answer.Append("Нечётные элементы меньше " + target.ToString() + ": ");
            for (int i = 0; i < arr?.Count; ++i)
            {
                if (i % 2 != 0 && arr[i] < target)
                {
                    answer.Append(arr[i].ToString() + " ");
                }
            }
            return answer.ToString();
        }
    }
}

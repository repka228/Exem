﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exem
{
    public class Task1_class
    {
        private int[]? arr;
        int size;
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
        }
        public string Task1()
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
        public string Task1(int target)
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

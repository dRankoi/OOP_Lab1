﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    public class MyList<T>
    {
        public T[] list;

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public int Count
        {
            get => list.Length;
        }
        public void Append(T element)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = element;
        }
    }
}

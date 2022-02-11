using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    public class MyDictionary<TKey, TValue>
    {
        private int counter = 0;
        private TKey[] KeysArray = null;
        private TValue[] ValuesArray = null;

        public int Counter
        {
            get { return this.counter; }
        }

        public void Addition(TKey key, TValue value)
        {
            this.counter++;

            Array.Resize(ref KeysArray, counter);
            KeysArray[counter - 1] = key;

            Array.Resize(ref ValuesArray, counter);
            ValuesArray[counter - 1] = value;
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < KeysArray.Length; i++)
                {
                    if (key.Equals(KeysArray[i]))
                        index = i;
                }
                return ValuesArray[index];
            }
        }


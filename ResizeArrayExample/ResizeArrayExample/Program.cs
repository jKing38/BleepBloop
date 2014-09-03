using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ResizableArray arr = new ResizableArray();
            string userInput;

            do
            {
                Console.Write("Enter a number or Q to quit: ");
                userInput = Console.ReadLine();

                int number;
                if (int.TryParse(userInput, out number))
                {
                    arr.Add(number);
                }
            } while (userInput != "Q");
        }
    }
    class ResizableArray
    {
        private int[] _myArray;
        private int _currentIndex = 0;
        private int _capacity;

        public ResizableArray()
        {
            _capacity = 2;
            _myArray = new int[_capacity];
            _currentIndex = 0;
        }
        public void Add(int number)
        {
            if (_currentIndex == _capacity)
            {
                IncreaseCapacity();
            }

            _myArray[_currentIndex] = number;
            _currentIndex++;
        }

        private void IncreaseCapacity()
        {
            _capacity *= 2;
            int[] temp = new int[_capacity];

            for (int i = 0; i < _myArray.Length; i++)
            {
                temp[i] = _myArray[i];
            }
            _myArray = temp;
        }

        public int Remove(int index)
        {
            if (index < 0 || index >= _currentIndex)
            {
                throw new IndexOutOfRangeException();
            }

            int number = _myArray[index];

            //shift left
            for (int i = index + 1; i < _currentIndex; i++)
            {
                _myArray[i] = _myArray[i + 1];
            }

            //decrement currentindex
            _currentIndex--;
            return number;
        }

        public int Get(int index)
        {
            return 0;
        }
    }
}

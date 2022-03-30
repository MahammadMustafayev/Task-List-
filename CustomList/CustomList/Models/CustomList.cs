using System;
using System.Collections.Generic;
using System.Text;
using CustomList.Models;

namespace CustomList.Models
{
    class CustomList<T>
    {
        private T[] _tempList;
        private T[] _array;
        private T[] _customList;
        private int _capacity;
        private int _count;
        public int Count
        {
            get
            {
                //return _customList.Length;
                return _count++;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (Capacity > Count)
                {
                    _capacity = value;
                }
            }
        }
       
        public CustomList(params T[] nums)
        {
            _customList = new T[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                _customList[i] = nums[i];
            }
        }
        public T this[int index]
        {
            get
            {
                return _customList[index];
            }
            set
            {
                _customList[index] = value;
            }
        }
        public void Add(T input)
        {
            Array.Resize(ref _customList, _customList.Length + 1);
            _customList[_customList.Length - 1] = input;
            Console.WriteLine(input);
        }
        public int IndexOf(T input)
        {
            for (int i = 0; i < _customList.Length; i++)
            {
                if (_customList[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T input)
        {
            for (int i = _customList.Length - 1; i > 0; i--)
            {
                if (_customList[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            for (int i = _customList.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_customList[i]);
            }
        }
        public void Clear()
        {
            Array.Resize(ref _customList, 0);
        }
        public void Remove(T input)
        {
            int index = IndexOf(input);
            Remove(input);
        }
        public bool Exist(T input)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array.Equals(input))
                {
                    return true;
                }
            }
            return false;
        }
        public void Show()
        {
            foreach (T item in _customList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

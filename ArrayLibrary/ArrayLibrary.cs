using System;

namespace ArrayLibrary
{
    public class ArrayList
    {
        private int[] _array;

        private int _currentCount;

        public int Length => _currentCount;

        public ArrayList()
        {
            _array = new int[5];
            _currentCount = 0;
        }

        public ArrayList(int[] arrayList)
        {
            _array = arrayList;
            _currentCount = arrayList.Length;
        }

        public ArrayList(int arrayZeroElement)
        {
            _array[0] = arrayZeroElement;
            _currentCount = 1;
        }

        public int[] ToArray()
        {
            int[] result = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                result[i] = _array[i];
            }

            return result;
        }

        public int this[int i]
        {
            get
            {
                if(i>= 0 && i < _currentCount)
                {
                    return _array[i];
                }

                throw new ArgumentException("Index was out of range");
            }
        }

        public void AddInEnd(int number)
        {
            if (_currentCount != _array.Length)
            {
                _array[_currentCount] = number;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length * 1.33)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_currentCount] = number;
                _array = newArray;
            }

            ++_currentCount;
        }

        public void AddArrayInEnd(int[] number)
        {
            if (_currentCount != _array.Length)
            {
                _array[_currentCount] = number.Length;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length * 1.33)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                //newArray[_currentCount] = number;
                _array = newArray;
            }

            ++_currentCount;
        }

        public void AddInStart(int number)
        {
            int[] newArray = new int[(int)(_array.Length * 1.33)];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            newArray[0] = number;
            _array = newArray;
        }

        public void AddByIndex(int number, int index)
        {
            int[] newArray = new int[(int)(_array.Length * 1.33)];
            for (int i = 0; i < _array.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = _array[i];
                }
                else
                {
                    newArray[i + 1] = _array[i];
                }
            }
            newArray[index] = number;
            _array = newArray;
        }

        public void ChangeByIndex(int number, int index)
        {
            int[] newArray = new int[(int)(_array.Length)];
            for (int i = 0; i < _array.Length; i++)
            {
                if (index == i)
                {
                    newArray[i] = number;
                }
                else
                {
                    newArray[i] = _array[i];
                }
            }
            _array = newArray;
        }

        public int ArrayListMinID()
        {
            int minID = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < _array[minID])
                {
                    minID = i;
                }
            }

            return minID;
        }

        public int ArrayListMaxID()
        {
            int maxID = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > _array[maxID])
                {
                    maxID = i;
                }
            }

            return maxID;
        }

        public int ArrayListMin()
        {
            return _array[ArrayListMinID()];
        }

        public int ArrayListMax()
        {
            return _array[ArrayListMaxID()];
        }

        public int DeleteByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < _currentCount; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            --_currentCount;
            for (int i = index; i < _currentCount; i++)
            {
                _array[i] = _array[i + 1];
            }

            return index;
        }

        public void RemoveFromEnd()
        {
            int[] newArray = new int[(int)(_array.Length - 1)];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public void RemoveFromStart()
        {
            int[] newArray = new int[(int)(_array.Length-1)];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i+1];
            }
            _array = newArray;
        }

        public void RemoveByIndex(int index)
        {
            int[] newArray = new int[(int)(_array.Length - 1)];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                    newArray[i] = _array[i];
                else
                    newArray[i] = _array[i + 1];
            }
            _array = newArray;
        }

        public void RemoveFromEndN(int count)
        {
            int[] newArray = new int[(int)(_array.Length - count)];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        public void RemoveFromStartN(int count)
        {
            int[] newArray = new int[(int)(_array.Length - count)];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + count];
            }
            _array = newArray;
        }

        public void RemoveByIndexN(int count, int index)
        {
            int[] newArray = new int[(int)(_array.Length - count)];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                    newArray[i] = _array[i];
                else
                    newArray[i] = _array[i + count];
            }
            _array = newArray;
        }

        public void ArrayReverse()
        {
            int i = 0;
            int j = _array.Length - 1;
            for (i = 0; i < j; i++)
            {
                Swap(ref _array[i], ref _array[j]);
                j--;
            }

            int[] newArray = new int[_array.Length];
            for (i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
        }

        public void AddArrayInEnd(ArrayList arrayList)
        {
            int[] newArray = new int[(int)(_array.Length + arrayList._array.Length)];

            int j = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < _array.Length)
                    newArray[i] = _array[i];
                else
                {
                    newArray[i] = arrayList._array[j];
                    j++;
                }
            }
            _array = newArray;
        }

        public void AddArrayInStart(ArrayList arrayList)
        {
            int[] newArray = new int[(int)(_array.Length + arrayList._array.Length)];

            int j = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < _array.Length)
                    newArray[i] = arrayList._array[j];
                else
                {
                    newArray[i] = _array[j];
                    j++;
                }
            }
            _array = newArray;
        }

        public void ArraySortUp()
        {
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        Swap(ref _array[i], ref _array[j]);
                    }
                }
            }
            //int[] newArray = new int[_array.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
        }

        public void ArraySortDown()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        Swap(ref _array[i], ref _array[j]);
                    }
                }
            }
            int[] newArray = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
        }

        public void AddArrayByIndex(ArrayList arrayList, int index)
        {
            int[] newArray = new int[(int)(_array.Length + arrayList._array.Length)];

            int j = 0;
            int n = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < index)
                {
                    newArray[i] = _array[j];
                    j++;
                }
                else if (n < arrayList._array.Length)
                {
                    newArray[i] = arrayList._array[n];
                    n++;
                }
                else if (j < _array.Length)
                {
                    newArray[i] = _array[j];
                    j++;
                }
            }
            _array = newArray;
        }

        public void Print()
        {
            Console.Write(string.Join(" ", _array));
        }

        public int IndexOfElement(int value)
        {
            int index = -1;
            for (int i = 0; i < _currentCount; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                }
            }
            return index;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void EmptyArray()
        {
            if (_array == null || _array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
        }
    }
}

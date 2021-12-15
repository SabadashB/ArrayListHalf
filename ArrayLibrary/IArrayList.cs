﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public interface IArrayList : IEnumerable<int>
    {
        void AddFront(int element);
        void AddBack(int element);
        void AddByIndex(int index, int element);
        int RemoveFront();
        int RemoveBack();
        int RemoveByIndex(int index);
        int[] RemoveFront(int count);
        int[] RemoveBack(int count);
        int[] RemoveByIndex(int index, int count);
        int Length { get; }//4
        int this[int index] { get; set; }
        int IndexOf(int element);
        void Reverse();//8
        int Max();
        int Min();
        int MaxI();
        int MinI();
        void Sort(bool ascending = true);
        int Remove(int value);
        int RemoveAll(int value);
        void AddFront(IArrayList arrayList);
        void AddBack(IArrayList arrayList);
        void AddByIndex(int index, IArrayList arrayList);
        int[] ToArray();
    }
}

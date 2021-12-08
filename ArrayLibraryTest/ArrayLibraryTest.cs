using NUnit.Framework;
using ArrayLibrary;
using System;

namespace ArrayLibraryTest
{
    public class ArrayLibraryTest
    {
        [TestCase(new[] { 1, 2, 3, 4 })]
        public void AddInEnd_WhenSomeElementAdded_ShouldFiilNewArrayList(int[] sourceArray)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddInEnd(sourceArray[i]);
            }
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Assert.AreEqual(sourceArray[i], arrayList[i]);
            }
        }

        [TestCase(new[] { 1, 2, 3, 4 },new[]{ 1, 2, 3, 4, 5 })]
        public void AddInEnd_WhenAddIsNotEmpty_ShouldAddElemenyInNewArrayList(int[] sourceArray,
            int[] expectedArray)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddInEnd(sourceArray[i]);
            }
            arrayList.AddInEnd(5);
            for (int i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], arrayList[i]);
            }
        }


    }
}
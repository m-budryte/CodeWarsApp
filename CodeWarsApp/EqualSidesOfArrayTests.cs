using NUnit.Framework;

namespace CodeWarsApp
{
    public class EqualSidesOfArrayTests
    {
        [TestCase(new int[] {1,2,3,4,3,2,1}, 3)]
        [TestCase(new int[] {1,100,50,-51,1,1}, 1)]
        [TestCase(new int[] {1,2,3,4,5,6}, -1)]
        [TestCase(new int[] {20,10,30,10,10,15,35}, 3)]
        [TestCase(new int[] {20,10,-80,10,10,15,35}, 0)]
        public void GenericTests(int[] array, int expected)
        {
            Assert.AreEqual(expected, EqualSidesOfArrayExercise.FindEvenIndex(array));
        }
    }
}
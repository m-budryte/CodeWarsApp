namespace CodeWarsApp
{
    using NUnit.Framework;

    public class ReverseWordsTests
    {
        [Test]
        public void Test()
            {
                Assert.AreEqual("sihT si na !elpmaxe", ReverseWordsExercise.ReverseWords("This is an example!"));
            }
        }
}
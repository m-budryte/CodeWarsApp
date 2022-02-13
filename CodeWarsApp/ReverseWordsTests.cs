namespace CodeWarsApp
{
    using NUnit.Framework;

    public class ReverseWordsTests
    {
        [TestFixture]
        public class Tests
        {
            [Test]
            public void Example()
            {
                Assert.AreEqual("sihT si na !elpmaxe", ReverseWordsExercise.ReverseWords("This is an example!"));
            }
        }
    }
}
using NUnit.Framework;

namespace CodeWarsApp
{
    public class ComplimentaryDNATests
    {
        [TestCase("AAAA", "TTTT")]
        [TestCase("ATTGC", "TAACG")]
        [TestCase("GTAT", "CATA")]
        [TestCase("AAGG", "TTCC")]
        [TestCase("CGCG", "GCGC")]
        [TestCase("ATTGC", "TAACG")]
        [TestCase("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
        public void SampleTests(string dna, string expected)
        {
            Assert.AreEqual(expected, ComplementaryDNAExercise.MakeComplement(dna));
        }
    }
}
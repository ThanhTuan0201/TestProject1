using StudentServiceLib;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Whenscoreis7_lettershouldbeB()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Whenscoreis8_lettershouldbeA()
        {
            Student s = new Student();
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Whenscoreis5_lettershouldbeC()
        {
            Student s = new Student();
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);



        }
        [TestMethod]
        public void Whenscoreis4_lettershouldbeD()
        {
            Student s = new Student();
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);

        }
    }
}
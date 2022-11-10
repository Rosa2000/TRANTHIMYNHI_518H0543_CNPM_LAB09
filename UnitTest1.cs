using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenScoreIs8_ReturnLetter_A()
        {
            Student s = new Student();
            s.Score = 8.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScoreIs10_ReturnLetter_A()
        {
            Student s = new Student();
            s.Score = 10.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScoreIs7_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 7.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void WhenScoreIs5_ReturnLetter_C()
        {
            Student s = new Student();
            s.Score = 5.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void WhenScoreIs35_ReturnLetter_D()
        {
            Student s = new Student();
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Assign11ToScore_ThrowException()
        {
            Student s = new Student();
            bool thrown = false;
            try
            {
                s.Score = 11;
            }
            catch(Exception ex)
            {
                thrown = true;
            }

            Assert.IsTrue(thrown);
        }

        [TestMethod]
        public void AssignNegativeValueToScore_ThrowException()
        {
            Student s = new Student();
            bool thrown = false;
            try
            {
                s.Score = -3;
            }
            catch (Exception ex)
            {
                thrown = true;
            }

            Assert.IsTrue(thrown);
        }

        [TestMethod]
        public void Assign0To10ToScore_NotThrowException()
        {
            Student s = new Student();
            bool thrown = true;
            try
            {
                s.Score = 8;
            }
            catch (Exception ex)
            {
                thrown = false;
            }

            Assert.IsTrue(thrown);
        }


        [TestMethod]
        public void AddStudent()
        {
            Student s = new Student();
            bool rfr = false;
            try
            {
                s.Id = 123;
            }
            catch(NullReferenceException n)
            {
                rfr = true;
            }
            Assert.IsTrue(rfr);



            
            
        }
    }
}
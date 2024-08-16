using solution_Kata;

namespace KataTest
{
    public class TestsKata_01_01
    {
        [Test]
        public void Test1()
        {
            int inData = 45296;

            string right_result = "12:34:56";

            string result = Kata_01.GetReadableTime(inData);

            Assert.That(result, Is.EqualTo(right_result));
        }
        [Test]
        public void Test2()
        {
            int inData = 86399;

            string right_result = "23:59:59";

            string result = Kata_01.GetReadableTime(inData);

            Assert.That(result, Is.EqualTo(right_result));
        }
        [Test]
        public void Test3()
        {
            int inData = 90;

            string right_result = "00:01:30";

            string result = Kata_01.GetReadableTime(inData);

            Assert.That(result, Is.EqualTo(right_result));
        }
    }
}
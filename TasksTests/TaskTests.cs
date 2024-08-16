using Tasks_01;

namespace TasksTests
{
    public class TestsTasks_01_01
    {

        [Test]
        public void Test1()
        {
            int rightData_1 = 2;

            int rightData_2 = 1;

            int result = Task_01_01.Swap<int>(1, 2, out int Data_1, out int Data_2);

            Assert.That(Data_1, Is.EqualTo(rightData_1));

            Assert.That(Data_2, Is.EqualTo(rightData_2));
        }
        [Test]
        public void Test2()
        {
            string rightData_1 = " Hello";

            string rightData_2 = " World";

            string result = Task_01_01.Swap<string>(" World", " Hello", out string Data_1, out string Data_2);

            Assert.That(Data_1, Is.EqualTo(rightData_1));

            Assert.That(Data_2, Is.EqualTo(rightData_2));
        }
        [Test]
        public void Test3()
        {
            bool rightData_1 = true;

            bool rightData_2 = false;

            bool result = Task_01_01.Swap<bool>(false, true, out bool Data_1, out bool Data_2);

            Assert.That(Data_1, Is.EqualTo(rightData_1));

            Assert.That(Data_2, Is.EqualTo(rightData_2));
        }
    }

    public class TestsTasks_01_02
    {
        [Test]
        public void Test1() 
        {
            var rightList = new List<string>() { "Tom", "Bob", "Sam", "Nik", "Ivan"};

            string p_0 = "Tom";

            string p_1 = "Bob";

            string p_2 = "Sam";

            string p_3 = "Nik";

            string p_4 = "Ivan";

            var list = Task_01_02.list(p_0, p_1, p_2, p_3, p_4);

            Assert.That(list, Is.EqualTo(rightList));
        }
    }
}
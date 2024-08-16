namespace Tasks_01
{
    public class Task_01_01
    {
        
        public static T Swap<T>(T Data_1, T Data_2, out T OutData_1, out T OutData_2)
        {
            T x = Data_1;

            OutData_1 = Data_2;

            OutData_2 = x;

            return x;
        }
        static public void Solution()
        {
            Task_01_01 tasks = new Task_01_01();

            string num_1 = "num_1";

            string num_2 = "num_2";

            string Data_1;

            string Data_2;

            string result = Swap<string>(num_1, num_2, out Data_1, out Data_2);
        }
    }

    public class Task_01_02
    {
        public static List<string> list(string str1, string str2, string str3, string str4, string str5)
        {
            var people = new List<string>() { str1, str2, str3, str4, str5};

            return people;
        }
        public static void Main() 
        {

            string p_0 = "Tom";

            string p_1 = "Bob";

            string p_2 = "Sam";

            string p_3 = "Nik";

            string p_4 = "Ivan";

            List<string> people = list( p_0, p_1, p_2, p_3, p_4);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}

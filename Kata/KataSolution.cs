namespace solution_Kata
{
    public class Kata_01
    {
        public static string GetReadableTime(int seconds)
        {
            string result = "00:00:00";

            int hh = 0;
            int h_1 = 0;
            int h_2 = 0;
            int mm = 0;
            int m_1 = 0;
            int m_2 = 0;
            int ss = 0;
            int s_1 = 0;
            int s_2 = 0;

            if (seconds > 0)
            {
                hh = seconds / 3600;
                h_1 = hh / 10;
                h_2 = hh % 10;

                mm = (seconds % 3600) / 60;
                m_1 = mm / 10;
                m_2 = mm % 10;

                ss = (seconds % 3600) % 60;
                s_1 = ss / 10;
                s_2 = ss % 10;
            }

            result = $"{h_1}{h_2}:{m_1}{m_2}:{s_1}{s_2}";

            return result;
        }
        public static void Main()
        {
            Console.WriteLine(GetReadableTime(45296));
        }
    }
}

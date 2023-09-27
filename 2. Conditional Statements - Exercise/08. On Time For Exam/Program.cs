namespace _08._On_Time_For_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrH = int.Parse(Console.ReadLine());
            int arrM = int.Parse(Console.ReadLine());

            int examTotalM = examH * 60 + examM;
            int arrTotalM = arrH * 60 + arrM;

            string arrived = "";
            string status = "";

            int diff = examTotalM - arrTotalM;

            if (diff >= 0 && diff <= 30)
            {
                arrived = "On time";
                status = "before";
            }
            else if (diff < 0)
            {
                arrived = "Late";
                status = "after";
                diff = -diff;
            }
            else
            {
                arrived = "Early";
                status = "before";
            }

            int compH = diff / 60;
            int compM = diff % 60;

            Console.WriteLine($"{arrived}");
            if (compH > 0)
            {
                Console.WriteLine($"{compH}:{compM:D2} hours {status} the start");
            }
            else if (compM > 0)
            {
                Console.WriteLine($"{compM} minutes {status} the start");
            }
        }
    }
}
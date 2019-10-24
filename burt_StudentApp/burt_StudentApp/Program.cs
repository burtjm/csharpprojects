using System;

namespace burt_StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.Display("Student APP");
            StudentUI stud = new StudentUI();
            stud.MainMethod();

      

        }
    }
}

using IO = System.Console;

namespace Lab3
{
    class Show
    {
        public static void SetWindowSize(int x, int y)
        {
            IO.SetWindowSize(x, y);
        }

        public static void InstructorCreationMessage(string name, string course)
        {
            string toShow = "";

            toShow += "Instructor ";
            toShow += name;
            toShow += " added instructing ";
            toShow += course;
            Format(toShow);
        }

        public static void StudentCreationMessage(string name, Instructor teach)
        {
            string toShow = "";

            toShow += "Student ";
            toShow += name;
            toShow += " has joined ";
            toShow += teach.GetName() + "'s ";
            toShow += teach.GetCourse();
            toShow += " class";
            Format(toShow);
        }

        public static void GradeChangeMessage(Instructor teach, Student student, int grade)
        {
            string toShow = "";

            toShow += teach.GetName();
            toShow += " changed ";
            toShow += student.GetName() + "'s ";
            toShow += "grade in ";
            toShow += teach.GetCourse();
            toShow += " to ";
            toShow += grade;
            Format(toShow);
        }

        public static void PrintInfo(Instructor teach)
        {
            Format("Instructor: " + teach.GetName());
            Format("Course: " + teach.GetCourse());
        }

        public static void PrintInfo(Student student)
        {
            Format("Student Name: " + student.GetName());
            Format("Grade: " + student.Grade);
            PrintInfo(student.GetInstructor());
        }

        public static void Write(string toShow)
        {
            IO.Write(toShow);
        }

        public static void ReadKey()
        {
            IO.ReadKey();
        }

        public static void Divider()
        {
            // 50 char wide
            IO.WriteLine("+------------------------------------------------+");
        }

        public static void NewLine()
        {
            Format("");
        }

        public static void Format(string toBeFormatted)
        {
            IO.WriteLine("|" + toBeFormatted.PadRight(48) + "|");
        }
    }
}

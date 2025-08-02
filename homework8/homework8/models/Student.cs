//IsGraduated constructor işə düşdükdə gelen Point field-nə əsasən təyin olunmalıdır(65-den aşagidirsa kesilib).
namespace homework8.models
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group,  int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = CheckGraduation(Point);
        }

        public bool CheckGraduation(int point)
        {
            bool result=true;
            if (point >= 65)
            {
            }
            else
            {
                result = false;
            }
                return result;   
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname:{Surname}, Group:{Group}, Point:{Point}, Is graduated: {IsGraduated}");
        }

        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("No Diplom");
            }
            else if(Point>=65 && Point < 80)
            {
                Console.WriteLine("Adi Diplom");
            }
            else if(Point>=80 && Point <90)
            {
                Console.WriteLine("Seref Diplomu");
            }
            else
            {
                Console.WriteLine("Yuksek Seref Diplomu");
            }
        }
    }
}

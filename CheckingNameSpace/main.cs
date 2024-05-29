
namespace School
{

  public class Program
  {

    public static void Main(string[] args)
    {
      Student student1 = new Student("Gurusudhan", 12);
      Student student2 = new Student("Gokul", 11);
      School.ShowStudent();

      School.RemoveStudent(student1);
      School.ShowStudent();
    }
  }
}


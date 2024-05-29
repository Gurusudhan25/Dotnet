namespace School
{

  public  abstract class School
  {
    public static List<Student> students = new List<Student> { };

    public static void ShowStudent()
    {
      foreach (Student student in students) 
      {
        Console.WriteLine("{0} {1}", student.Name, student.Class);
      }
    }

    public static void AddStudent(Student studentName)
    {
      students = students.Append(studentName).ToList();
    }

    public static void RemoveStudent(Student studentName)
    {
      bool isRemoved = students.Remove(studentName);
      Console.WriteLine("removed one student");
    }

    static School()
    {
      Console.WriteLine("In school");
    }
  }
}
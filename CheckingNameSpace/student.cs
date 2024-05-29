namespace School
{
  public class Student
  {
    public string Name;
    public int Class;

    public Student(string name, int std)
    {
      Name = name;
      Class = std;
      School.AddStudent(this);
    }
  }
}
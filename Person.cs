using System

namespace ClassesTraining {

  public class Person {
    public static int PeopleCount = 0;
    public string Name;
    public void Introduce () {
      Console.WriteLine ("Hello, my name is " + Name);
    }

  }

}
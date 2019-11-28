using System;

namespace ClassesTraining {
  class Program {
    static void Main (string[] args) {
      // Person person = new Person();
      var person = new Person ();
      person.Name = "Joe";
      person.Introduce ();

      var person2 = new Person {
        FirstName = "Joe",
        LastName = "Doe"
      };
    }
  }
}
using System.Collections.Generic;

namespace ClassesTraining {
  public class Customer {
    public string Name;
    public int Id;
    public List<Order> Orders;

    public Customer () {
      Orders = new List<Order> ();
    };
    public Customer (int id) : this () {

      this.Id = id;
    };
    public Customer (int id, string name) : this () {
      this.Name = name;
      this.Id = id;
    };
  }
}
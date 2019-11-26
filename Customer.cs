namespace ClassesTraining {
  public class Customer {
    public string Name;
    public int Id;

    public Customer (int id) {
      this.Id = id;
    };
    public Customer (int id, string name) {
      this.Name = name;
      this.Id = id;
    };
  }
}
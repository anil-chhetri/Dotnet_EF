public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }

    public static List<Employee> GetEmployee()
    {
        return new List<Employee> {
            new Employee { Id = 1, Name="Mark", Gender="Male", Department="IT", Salary=450000},
            new Employee { Id = 2, Name="Steve", Gender="Male", Department="HR", Salary=550000},
            new Employee { Id = 3, Name="Ben", Gender="Male", Department="IT", Salary=450000},
            new Employee { Id = 4, Name="Philip", Gender="Male", Department="IT", Salary=550000},
            new Employee { Id = 5, Name="Mary", Gender="Female", Department="HR", Salary=480000},
            new Employee { Id = 6, Name="Valarie", Gender="Female", Department="HR", Salary=70000},
            new Employee { Id = 7, Name="John", Gender="Male", Department="IT", Salary=640000},
            new Employee { Id = 8, Name="Pam", Gender="Female", Department="IT", Salary=45000},
            new Employee { Id = 9, Name="Stacey", Gender="Female", Department="HR", Salary=54000},
            new Employee { Id = 10, Name="Andy", Gender="Male", Department="IT", Salary=36000}
        };
    }

}
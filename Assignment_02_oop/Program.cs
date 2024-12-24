namespace Assignment_02_oop
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            try
            {
                
                Employee[] EmpArray = new Employee[3];

                EmpArray[0] = new Employee(1, "Mohammed Eshag", "M", SecurityLevel.DBA, 10000m, new HiringDate(24, 4, 1998));
                EmpArray[1] = new Employee(2, "Wejdan Abdalla", "F", SecurityLevel.Guest, 4000m, new HiringDate(1, 1, 1998));
                EmpArray[2] = new Employee(3, "Omer Khaled", "M", SecurityLevel.Developer, 20000m, new HiringDate(1, 1, 1990));

             
                foreach (var emp in EmpArray)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

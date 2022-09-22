// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using OrganizationLib; 
namespace ConsoleAppSheet1{
	public class Program{
		static List<Person> people = new List<Person>();
		public static void Main(string[] args){
			Console.WriteLine("Hello IS");
			Customer c = new Customer("A", "Doe", new DateOnly(1995, 5, 20), "stuff");
			Customer c2 = new Customer("Abacus", "Doe", new DateOnly(1995, 5, 20), "Leiria");
			Customer c3 = new Customer("C", "Doe", new DateOnly(1995, 5, 20), "Lisboa");
			
			Manager manager = new Manager("John", "Doe", new DateOnly(1990, 1, 1), 1000f);

			Programmer programmer1 = new Programmer("John", "Doe", new DateOnly(1960, 1, 1), 200f);
			Programmer programmer2 = new Programmer("Jane", "Doe", new DateOnly(1990, 1, 1), 200f);
			Programmer programmer3 = new Programmer("Kate", "Doe", new DateOnly(1930, 1, 1), 200f);
			Programmer programmer4 = new Programmer("Frick", "Doe", new DateOnly(1890, 1, 1), 200f);
			Programmer programmer5 = new Programmer("Men", "Doe", new DateOnly(1990, 1, 1), 200f);
			people.Add(c);
			people.Add(c2);
			people.Add(c3); 
			manager.AddProgrammer(programmer1); 
			manager.AddProgrammer(programmer2);
			manager.AddProgrammer(programmer3);
			manager.AddProgrammer(programmer4);
			manager.AddProgrammer(programmer5);
			people.Add(manager);
			people.Add(programmer1);
			people.Add(programmer2);
			people.Add(programmer3);
			people.Add(programmer4);
			people.Add(programmer5);
			
			//Linq exe 1
			IEnumerable<Customer> query = from p in people
						where p is Customer && p.FullName.First() == 'A'
						select (Customer)p;

			//Linq exe 2
			IEnumerable<Customer> query2 = from p in query
						where p.Address=="Leiria"
						select p;
			//Linq exe 3
			int numberOf40yos = (from p in people
								where p.Age >= 40
								select p).Count();
								
			foreach (var item in query){
				Console.WriteLine("------\n"+item.print());
		    }
			foreach (var item in query2){
				Console.WriteLine("------\n"+item.print());
		    }
			Console.WriteLine("\n||Number: "+numberOf40yos); 					
			Console.WriteLine(manager.print()); 
			Console.ReadLine();
			
		}
	}	
}

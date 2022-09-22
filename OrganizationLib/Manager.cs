using System;

namespace OrganizationLib{
	public class Manager : Employee{
		private List<Programmer> _programmers; 
		public int NumberOfProgrammers {get{return _programmers.Count;}}
		// Indexer for _programmers
		public Programmer this[int index]{
			get{
				return _programmers[index];
			}
			set{
				_programmers[index]=value;
			}
		}
		public Programmer AddProgrammer(Programmer programmer){
			_programmers.Add(programmer);
			return programmer;
		}

		public Manager(string _firstName, string _lastName, DateOnly _birthDate, float salary) : base(_firstName, _lastName, _birthDate, salary){
			_programmers = new List<Programmer>();
		}
		public override string print(){
			string result = "-_- Manager -_-\n"+"Name is: "+this.FullName+";\nAge is: "+this.Age.ToString()+";\nSalary is: "+this.Salary.ToString()+"\nNumber of active personnel: "+this.NumberOfProgrammers+";\n-_- -_- -_-"; 
			result+="\t\n{"; 
			foreach (var item in _programmers){
				result += "\t\n"+item.print();
			}
			result+="\t\n}";
			return result;
		}
	}
}

using System;

namespace OrganizationLib
{
	public class Employee : Person{
		private float _salary;
		#region props 
		public virtual float Salary{
			get{
				return _salary;
			}
			set{
				_salary = value;
			}
		}
		#endregion
		public Employee(string _firstName, string _lastName, DateOnly _birthDate, float salary) : base(_firstName, _lastName, _birthDate){
			this.Salary=salary;
		}
		public override string print(){
			return "-_- Employee -_-\n"+"Name is: "+this.FullName+";\nAge is: "+this.Age.ToString()+";\nSalary is: "+this.Salary.ToString()+";\n-_- -_- -_-"; 
		}
	}


}

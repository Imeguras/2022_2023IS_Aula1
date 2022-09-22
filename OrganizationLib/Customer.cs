using System;

namespace OrganizationLib
{
	public class Customer : Person{
		public string Address{get; set;}
		public Customer(string _firstName, string _lastName, DateOnly _birthDate, string _address) : base(_firstName, _lastName, _birthDate){
			this.Address=_address;
		}
		public override string print(){
			return "-_- Customer -_-\n"+"Name is: "+this.FullName+";\nAge is: "+this.Age.ToString()+";\nAddress is: "+this.Address+";\n-_- -_- -_-"; 
		}
	}
}

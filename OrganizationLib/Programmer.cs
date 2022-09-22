using System;

namespace OrganizationLib
{
	public class Programmer : Employee
	{
		public Programmer(string _firstName, string _lastName, DateOnly _birthDate, float salary) : base(_firstName, _lastName, _birthDate, salary){
			
		}
	}
}

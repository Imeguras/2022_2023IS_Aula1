using System;

namespace OrganizationLib{
    public abstract class Person : IPrintable{
        private string _firstName;
		private string _lastName;
		private DateOnly _birthDate;
		public enum sexType {
				male=2,
				female=1,
				error=0
		}
			 
		#region props 
			public string FullName{get; }
			public int Age{get;}
			public DateOnly Birthdate {
				get{
					return _birthDate;
				}
				set{
					_birthDate = value;
				}
			}
			public sexType Gender{get; set;}

		#endregion
		public Person(string _firstName, string _lastName, DateOnly _birthDate){
			this._firstName = _firstName;
			this._lastName = _lastName;
			this._birthDate = _birthDate;
			FullName = $"{_firstName} {_lastName}";
			Age= DateTime.Now.Year - _birthDate.Year;
			
		}
		public virtual string print(){
			return "-_- Person -_-\n"+"Name is: "+this.FullName+";\nAge is: "+this.Age.ToString()+";\n-_- -_- -_-"; 
		}

    }
}

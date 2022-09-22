using System;

namespace OrganizationLib
{
    public class Persons : IPrintable{
		private List<Person> _persons;
		// indexer for _persons
		public Person this[int index]{
			get{
				return _persons[index];
			}
			set{
				_persons[index]=value;
			}
		}
		public Persons(){
			_persons = new List<Person>();

		}
		public Person AddPerson(Person person){
			if(person!=null){
				
				if(_persons.Any(p=>p.GetHashCode==person.GetHashCode)){
					throw new ExPersonAlreadyExists(person, this[_persons.FindIndex(p=>p.GetHashCode==person.GetHashCode)]); 
					 
				}
				_persons.Add(person);
				return person;
			}
			else{
				throw new ExPersonIsNull();
			}
		}
		public Person RemovePerson(Person person){
			if(person!=null){
				if(_persons.Any(p=>p.GetHashCode==person.GetHashCode)){
					_persons.Remove(person);
					return person;
				}
				else{
					throw new ExPersonNotFound();
				}
			}
			else{
				throw new ExPersonIsNull();
			}
		}
		public int NumberOfProgrammers{
			get{
				return _persons.Count(p=>p is Programmer);			
			}
		}
		public int NumberOfCustomers{
			get{
				return _persons.Count(p=>p is Customer);			
			}
		}
		public int NumberOfManagers{
			get{
				return _persons.Count(p=>p is Manager);			
			}
		}
		public int NumberOfPersons{
			get{
				return _persons.Count;			
			}
		}
		
		public virtual string print(){
			string result = "";
			foreach (var item in _persons)
			{
				result += item.print()+"\n";
			}
			return result;
		}		
    }
	public class ExPersonAlreadyExists : Exception{
		public ExPersonAlreadyExists(Person k, Person target) : base("A pessoa já existe, "+k.GetHashCode()+"/"+target.GetHashCode()+"\nalso heres the k/target"+ k.print()+"/"+target.print()){}
	}
	public class ExPersonIsNull : Exception{
		public ExPersonIsNull() : base("A pessoa é nula"){}
	}
	public class ExPersonNotFound : Exception{
		public ExPersonNotFound() : base("A pessoa não existe"){}
	}
}

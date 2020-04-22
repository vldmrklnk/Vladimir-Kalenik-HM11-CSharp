using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm11
{
	public abstract class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Department { get; set; }
		abstract public void Work();

	}

	public class Student : Person
	{
		public override void Work()
		{
			Console.WriteLine($"Меня зовут {this.Name}" +
				$" {this.Surname}. Я учусь на" +
				$" {this.Department} факультете.");
		}
		//public string TestWork(string essay)
		//{
		//	Console.WriteLine($"Тема моего эссе: {essay}");
		//	return essay;
		//}
		//public int TestWork(int solution)
		//{
		//	Console.WriteLine($"Решение задачи = {solution}");
		//	return solution;
		//}
		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType()) return false;
			Student student = (Student)obj;
			return (this.Name == student.Name & this.Surname == student.Surname);
		}

	}

	public class Professor : Person
	{
		public override void Work()
		{
			Console.WriteLine($"Меня зовут {this.Name}" +
				$" {this.Surname}. Я преподаю на" +
				$" {this.Department} факультете.");
		}
		//public void CheckTest(Student student)
		//{

		//}
	}

	class HeadOfDepartment : Person
	{
		public override void Work()
		{
			Console.WriteLine($"Меня зовут {this.Name}" +
				$" {this.Surname}." +
				$" Я заведую на {this.Department} факультете.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student();
			student.Name = "Petr";
			student.Surname = "Ivanov";
			string faculty = "Physics";
			student.Department = faculty;
			Professor professor = new Professor();
			professor.Name = "Igor";
			professor.Surname = "Popovich";
			professor.Department = faculty;
			HeadOfDepartment headOfDepartment = new HeadOfDepartment();
			headOfDepartment.Name = "Alex";
			headOfDepartment.Surname = "Muromets";
			headOfDepartment.Department = faculty;
			student.Work();
			professor.Work();
			headOfDepartment.Work();
			Student student1 = new Student();
			student1.Name = "Petr";
			student1.Surname = "Ivanov";
			Student student2 = new Student();
			student2.Name = "Seva";
			student2.Surname = "Ivanov";
			Console.WriteLine(student.Equals(student1));
			Console.WriteLine(student.Equals(student2));
			student1.Department = faculty;
			student2.Department = faculty;
			Console.ReadLine();
		}
	}
}

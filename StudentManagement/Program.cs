// See https://aka.ms/new-console-template for more information

using StudentManagement;

Student student1 = new() { Id = "1000000", Name = "Nguyen Phan Anh", Gender = true, DOB = new DateTime(2002, 12, 30), Class = "IT62A", Course = 62 };
Student student2 = new() { Id = "1000002", Name = "Nguyen Van A", Gender = true, DOB = new DateTime(2002, 5, 12), Class = "CS62", Course = 62 };
Student student3 = new() { Id = "1000003", Name = "Nguyen Thi B", Gender = false, DOB = new DateTime(2003, 8, 21), Class = "IT63B", Course = 63 };
Student student4 = new() { Id = "1000004", Name = "Nguyen Van B", Gender = true, DOB = new DateTime(2004, 1, 1), Class = "MIS64A", Course = 64 };

List<Student> students = new() { student1, student2, student3, student4 };

EnglishClass lopVan = new() { students = new() { student1, student2, student3 }, firstGrade = new(new double[3]), secondGrade = new(new double[3]) };
MathClass lopToan = new() { students = new() { student2, student3, student4 }, firstGrade = new(new double[3]), secondGrade = new(new double[3]) };

Menu();



void Menu()
{
	bool flag = true;
	while (flag == true)
	{
		Console.WriteLine("Menu quan ly sinh vien");
		Console.WriteLine("1 - Xem danh sach sinh vien");
		Console.WriteLine("2 - Xem mon hoc sinh vien dang ky");
		Console.WriteLine("3 - Nhap diem sinh vien");
		Console.WriteLine("4 - Xem diem sinh vien");
		Console.WriteLine("5 - Thoat");

		string? str = Console.ReadLine();
		switch (str)
		{
			case "1":
				Display();
				Console.ReadKey();
				Console.Clear();
				Menu();
				break;
			case "2":
				DisplaySubjects();
				Console.ReadKey();
				Console.Clear();
				Menu();
				break;
			case "3":
				Grading();
				Console.ReadKey();
				Console.Clear();
				Menu();
				break;
			case "4":
				DisplayGrade();
				Console.ReadKey();
				Console.Clear();
				Menu();
				break;
			case "5":
				flag = false;
				break;
			default:
				Menu();
				break;
		}
	}
}

void Display()
{
	Console.WriteLine("Danh sach sinh vien");
	Console.WriteLine("STT\tMSV\tHo ten\t\t\tGioi tinh\tNgay sinh\tLop\tKhoa");
	foreach (Student student in students)
	{
		Console.WriteLine($"{students.IndexOf(student)}\t{student.Id}\t{student.Name}\t\t{(student.Gender ? "Nam" : "Nu")}\t\t{student.DOB.ToString("dd/mm/yyyy")}\t{student.Class}\t{student.Course}");
	}

}

void DisplaySubjects()
{
	Console.WriteLine("Mon hoc sinh vien dang ky");
	Console.WriteLine("Lop Toan:");
	foreach (Student student in lopToan.students)
	{
		Console.WriteLine($"{lopToan.students.IndexOf(student)} - {student.Name}");
	}
	Console.WriteLine("Lop Van:");
	foreach (Student student in lopVan.students)
	{
		Console.WriteLine($"{lopVan.students.IndexOf(student)} - {student.Name}");
	}
}

void Grading()
{
	DisplaySubjects();
	Console.WriteLine("\n1 - Nhap diem Toan");
	Console.WriteLine("2 - Nhap diem Van");
	string str = Console.ReadLine();
	Console.WriteLine("Nhap STT sinh vien de nhap diem");
	int i = Convert.ToInt32(Console.ReadLine());

	switch (str)
	{
		case "1":
			lopToan.InsertGrade(i);
			break;
		case "2":
			lopVan.InsertGrade(i);
			break;
		default:
			break;
	}
}

void DisplayGrade()
{
	Console.WriteLine("Diem mon Toan");
	lopToan.DisplayGrade();
	Console.WriteLine("Diem mon Van");
	lopVan.DisplayGrade();

}

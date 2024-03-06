namespace StudentManagement
{
	public class EnglishClass : Classroom
	{
		public EnglishClass()
		{
			subject = new() { Name = "Van", NumberOfPeriod = 25 };
		}
		public override List<double> CalGrade()
		{
			List<double> DiemFinal = new(new double[students.Count]);
			for (int i = 0; i < students.Count; i++)
			{
				DiemFinal[i] = Math.Round(firstGrade[i] * 0.3 + secondGrade[i] * 0.7, 2);
			}
			return DiemFinal;
		}
		public void InsertGrade(int i)
		{
			Console.WriteLine("Nhap diem mon Van");
			Console.Write("Nhap diem qua trinh");
			firstGrade[i] = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nhap diem thanh phan");
			secondGrade[i] = Convert.ToDouble(Console.ReadLine());
		}
		public void DisplayGrade()
		{
			Console.WriteLine("Id\tHo ten\t\t\tDiem QT\tDiemTP\tDiem tong ket\tKet qua");
			for (int i = 0; i < students.Count; i++)
			{
				Console.WriteLine($"{students[i].Id}\t{students[i].Name}\t\t{firstGrade[i]}\t{secondGrade[i]}\t{CalGrade()[i]}\t\t{(CalGrade()[i] >= 4 ? "Do" : "Truot")}");
			}
		}
	}
}

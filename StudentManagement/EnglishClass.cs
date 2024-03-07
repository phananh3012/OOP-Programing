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
			List<double> FinalGrade = new(new double[students.Count]);
			for (int i = 0; i < students.Count; i++)
			{
				FinalGrade[i] = Math.Round(FirstGrade[i] * 0.3 + SecondGrade[i] * 0.7, 2);
			}
			return FinalGrade;
		}
		public void InsertGrade(int i)
		{
			Console.WriteLine("Nhap diem mon Van");
			Console.Write("Nhap diem qua trinh: ");
			FirstGrade[i] = Convert.ToDouble(Console.ReadLine());
			Console.Write("Nhap diem thanh phan: ");
			SecondGrade[i] = Convert.ToDouble(Console.ReadLine());
		}
		public void DisplayGrade()
		{
			Console.WriteLine("Id\tHo ten\t\t\tDiem QT\tDiemTP\tDiem tong ket\tKet qua");
			for (int i = 0; i < students.Count; i++)
			{
				Console.WriteLine($"{students[i].Id}\t{students[i].Name}\t\t{FirstGrade[i]}\t{SecondGrade[i]}\t{CalGrade()[i]}\t\t{(CalGrade()[i] >= 4 ? "Do" : "Truot")}");
			}
		}
	}
}

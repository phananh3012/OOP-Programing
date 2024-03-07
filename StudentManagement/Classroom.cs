namespace StudentManagement
{
	public abstract class Classroom
	{
		public List<Student> students { get; set; }
		public Subject? subject { get; set; }
		public List<double> FirstGrade { get; set; }
		public List<double> SecondGrade { get; set; }
		public abstract List<double> CalGrade();

	}
}

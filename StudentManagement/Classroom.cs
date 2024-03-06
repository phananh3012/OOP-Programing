namespace StudentManagement
{
	public abstract class Classroom
	{
		public List<Student> students { get; set; }
		public Subject? subject { get; set; }
		public List<double> firstGrade { get; set; }
		public List<double> secondGrade { get; set; }
		public abstract List<double> CalGrade();

	}
}

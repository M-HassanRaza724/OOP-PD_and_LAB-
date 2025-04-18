namespace Task1.BL
{
    class GradedCourse : Course
    {
        int Grade = -1;

        public GradedCourse(string coursename, double marks, int grade) : base(coursename, marks)
        {
            Grade = grade;
        }
        public GradedCourse(string coursename, double marks) : base(coursename, marks)
        {
        }
        public override bool CalculateGrade(double percentage)
        {
            if (percentage >= 90 && percentage <= 100)
            {
                Grade = 12;
            }
            else if (percentage >= 80 && percentage <= 89)
            {
                Grade = 10;
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Grade = 7;
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Grade = 4;
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Grade = 2;
            }
            else if (percentage >= 40 && percentage <= 49)
            {
                Grade = 0;
            }
            else if (percentage >= 0 && percentage <= 39)
            {
                Grade = -3;
            }
            else
            {
                return false;
            }
            return true;
        }
        public override bool Pass()
        {
            if (CalculateGrade(GetMarks()))
            {
                if (Grade == -3)
                    return false;
                else
                    return true;
            }
            else
            {
                throw new Exception("Invalid Marks");
            }
        }
    }
}

namespace Task1.BL
{
    class AbsoluteGradedCourse : Course
    {
        string Grade = "";
        public AbsoluteGradedCourse(string coursename, double marks) : base(coursename, marks)
        {
        }
        public override bool CalculateGrade(double percentage)
        {
            if (percentage >= 90 && percentage <= 100)
            {
                Grade = "A+ (Exceptional)";
            }
            else if (percentage >= 80 && percentage <= 89)
            {
                Grade = "A (Excellent)";
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Grade = "B (Good)";
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Grade = "C (Satisfactory)";
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Grade = "D (Barely acceptable)";
            }
            else if (percentage >= 0 && percentage <= 49)
            {
                Grade = "F (Unacceptable)";
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
                if (Grade == "F (Unacceptable)")
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

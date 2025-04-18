namespace Task1.BL
{
    class Project
    {
        string Name;
        Course[] Courses = new Course[4];

        public Project(string name, Course[] courses)
        {
            Name = name;
            Courses = courses;
        }
        public Project(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public Course[] GetCourses()
        {
            return Courses;
        }
        public void SetCourses(Course[] courses)
        {
            Courses = courses;
        }
        public void AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Length; i++)
            {
                if (Courses[i] == null)
                {
                    Courses[i] = course;
                    break;
                }
            }
        }
        public void DeleteCourse(Course course)
        {
            for (int i = 0; i < Courses.Length; i++)
            {
                if (Courses[i] == course)
                {
                    Courses[i] = null;
                    break;
                }
            }
        }
        public bool Pass()
        {
            int passedCourses = 0;
            foreach (Course course in Courses)
            {
                if (course != null && course.Pass())
                {
                    passedCourses++;
                }
            }
            if(passedCourses >= 3)
                return true;
            else 
                return false;
        }


    }
}

using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}

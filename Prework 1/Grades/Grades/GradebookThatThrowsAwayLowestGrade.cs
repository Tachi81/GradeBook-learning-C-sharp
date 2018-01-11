using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public class GradebookThatThrowsAwayLowestGrade : GradeBook
    {
        public GradebookThatThrowsAwayLowestGrade(string name)
            :base(name)
        {
            Console.WriteLine("throwaway ctor");
        }

        public override GradeStatistics ComputeStatistic()
        {
            float LowestGrade = 100;
            foreach (float grade in _grades)
            {
                LowestGrade = Math.Min(LowestGrade, grade);
            }
            _grades.Remove(LowestGrade); 
            return base.ComputeStatistic();
        }
    }
}

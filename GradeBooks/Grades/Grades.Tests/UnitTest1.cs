using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistic();


            Assert.AreEqual(90f, stats.HighestGrade);
        }


        //[TestMethod]
        //public void PassByValue()
        //{
        //    GradeBook book = new GradeBook();
        //    book.Name = "Not Set";
        //    SetName(book);

        //    Assert.AreEqual("Name Set", book.Name);
        //}

        //private void SetName(GradeBook book)
        //{
        //    book.Name = "Name Set";
        //}
    }
}

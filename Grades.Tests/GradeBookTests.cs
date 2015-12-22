using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHightestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);
            book.AddGrade(40);
            book.AddGrade(50);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(50, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);
            book.AddGrade(40);
            book.AddGrade(50);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(10, stats.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook.GradeBook book = new GradeBook.GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(30);
         

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(20, stats.AverageGrade);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 12, 21);
            date = date.AddDays(1);

            Assert.AreEqual(22, date.Day);
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "diego";
            name=name.ToUpper();
            Assert.AreEqual("DIEGO", name);
        }
     

 

        [TestMethod]
        public void ValueTypesPassedByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number++;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook.GradeBook book1 = new GradeBook.GradeBook();
            GradeBook.GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook.GradeBook book)
        {
            book.Name = "A GradeBook";
        }



        [TestMethod]
        public void GradeBookVariablesHoldAreReference()
        {
            GradeBook.GradeBook g1 = new GradeBook.GradeBook();
            GradeBook.GradeBook g2 = g1;

            g1.Name = "Diego's GradeBook";
            Assert.AreEqual(g1.Name, g2.Name);

        }

        [TestMethod]
        public void GradeBookVariablesHoldReference2()
        {
            GradeBook.GradeBook g1 = new GradeBook.GradeBook();
            GradeBook.GradeBook g2 = g1;

            g1 = new GradeBook.GradeBook();
            g1.Name = "Diego's GradeBook";
            Assert.AreNotEqual(g1.Name, g2.Name);

        }

        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void StringComparison()
        {
            string name = "Diego";
            string name2 = "diego";
            bool result = String.Equals(name, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }
    }
}

using NUnit.Framework;
using caAssignment1;

namespace Assignment1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_normal()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings.csv");
            Assert.That(result, Is.EqualTo("Generation completed!"));

            
        }

        [Test]
        public void Test2_Invalid_Header()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings_invalidheader.csv");
            Assert.That(result, Is.EqualTo("Invalid Header Name!"));

        }

        [Test]
        public void Test3_File_Not_Exist()
        {
            string result;
            result = Program.notebookAssignment("File_Not_Exist.csv");
            Assert.That(result, Is.EqualTo("Input file not existed!"));
        }

        [Test]
        public void Test4_Invalid_Header_Amount()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings_invalid_col_number.csv");
            Assert.That(result, Is.EqualTo("Invalid Header Number!"));
        }

        [Test]
        public void Test5_Invalid_Student_Name()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings_invalid_student_name.csv");
            Assert.That(result, Is.EqualTo("Student Name empty!"));
        }

        [Test]
        public void Test6_Invalid_column_Amount_For_Student()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings_invalid_student_col.csv");
            Assert.That(result, Is.EqualTo("Invalid Column Amount Of Student!"));
        }

        [Test]
        public void Test7_Invalid_Student_Rating_Value()
        {
            string result;
            result = Program.notebookAssignment("Class1_ratings_invalid_rating.csv");
            Assert.That(result, Is.EqualTo("Invalid Student Rating Type"));
        }


    }
}
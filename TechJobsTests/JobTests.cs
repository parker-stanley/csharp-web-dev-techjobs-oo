using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //why won't this work?
        //[TestInitialize]
        //public void CreateJobObject()
        //{
        //Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //}

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job2 = new Job();
            Job job3 = new Job();
            Assert.IsFalse(job2.Id == job3.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
            //is there a better way to do all of these on one line?
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void ToStringPrintsWithBlankLines()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.ToString().StartsWith("\n"));
            Assert.IsTrue(job1.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void ToStringPrintsJobValues()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("\n" +
                "ID: 7\n" +
                "Name: Product tester\n" +
                "Employer: ACME\n" +
                "Location: Desert\n" +
                "Position Type: Quality control\n" +
                "Core Competency: Persistence\n" +
                "\n", job1.ToString());
        }

        [TestMethod]
        public void ToStringWithEmptyFields()
        {
            Job job1 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("\n" +
                "ID: 7\n" +
                "Name: Product tester\n" +
                "Employer: Data not available\n" +
                "Location: Desert\n" +
                "Position Type: Quality control\n" +
                "Core Competency: Persistence\n" +
                "\n", job1.ToString());
        }

        //bonus test for later
        //[TestMethod]
        //public void ToStringWithAllEmptyFields()
        //{
        //    Job job2 = new Job();
        //    Assert.AreEqual("OOPS! This job does not seem to exist.", job2.ToString());
        //}

    }
}

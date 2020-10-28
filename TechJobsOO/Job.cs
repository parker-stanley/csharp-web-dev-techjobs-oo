using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors. DONE

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType position, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = position;
            JobCoreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods. DONE

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null) 
            {
                return "OOPS! This job does not seem to exist.";
            }

            //could've also done an array here and used .Length instead of .Count
            //string[] valueList = { Name, EmployerName.Value, EmployerLocation.Value, JobType.Value, JobCoreCompetency.Value};
            List<string> valueList = new List<string>();
            valueList.Add(Name);
            valueList.Add(EmployerName.Value);
            valueList.Add(EmployerLocation.Value);
            valueList.Add(JobType.Value);
            valueList.Add(JobCoreCompetency.Value);

            //note, i originally had a foreach loop but couldn't reassign the variable
            for (int i = 0; i < valueList.Count; i++)
            {
                if (valueList[i] == "")
                {
                    valueList[i] = "Data not available";
                }
            }

            return ($"\n" +
                $"ID: {Id}\n" +
                $"Name: {valueList[0]}\n" +
                $"Employer: {valueList[1]}\n" +
                $"Location: {valueList[2]}\n" +
                $"Position Type: {valueList[3]}\n" +
                $"Core Competency: {valueList[4]}\n" +
                $"\n");

            //original attempt at doing this, updated to loop through list
            //if (Name == "") this.Name = "Data not available";
            //if (EmployerName.Value == "") EmployerName.Value = "Data not available";
            //if (EmployerLocation.Value == "") EmployerLocation.Value = "Data not available";
            //if (JobType.Value == "") JobType.Value = "Data not available";
            //if (JobCoreCompetency.Value == "") JobCoreCompetency.Value = "Data not available";

            //return ($"\n" +
            //    $"ID: {Id}\n" +
            //    $"Name: {Name}\n" +
            //    $"Employer: {EmployerName.Value}\n" +
            //    $"Location: {EmployerLocation.Value}\n" +
            //    $"Position Type: {JobType.Value}\n" +
            //    $"Core Competency: {JobCoreCompetency.Value}\n" +
            //    $"\n");

            //note, the difference between using an array/list vs my original attempt is that
            //with the original method the actual values were replaced
        }

    }
}

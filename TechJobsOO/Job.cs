using System;

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

            //is there a better way to do this?
            //I could add curly braces here as well 
            if (Name == "") this.Name = "Data not available";
            if (EmployerName.Value == "") EmployerName.Value = "Data not available";
            if (EmployerLocation.Value == "") EmployerLocation.Value = "Data not available";
            if (JobType.Value == "") JobType.Value = "Data not available";
            if (JobCoreCompetency.Value == "") JobCoreCompetency.Value = "Data not available";

            return ($"\n" +
                $"ID: {this.Id}\n" +
                $"Name: {this.Name}\n" +
                $"Employer: {this.EmployerName.Value}\n" +
                $"Location: {this.EmployerLocation.Value}\n" +
                $"Position Type: {this.JobType.Value}\n" +
                $"Core Competency: {this.JobCoreCompetency.Value}\n" +
                $"\n");
        }

    }
}

using System;
namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Value;
        }

    }
}

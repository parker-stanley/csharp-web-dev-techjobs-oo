using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        public PositionType(string value) : base()
        {
            Value = value;
        }


        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods. DONE

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public override string ToString()
        //{
        //    return Value;
        //}

    }
}

using Newtonsoft.Json;
using System;
using System.Text;

namespace DemoApp.Models
{
    public class Emp : BaseObject
    {
        public Emp()
        {
        }

        public int EmpNo { get; set; }

        public string EName { get; set; }

        public string Job { get; set; }

        public int Mgr { get; set; }

        public DateTime? HireDate { get; set; }

        public double Sal { get; set; }

        public double Comm { get; set; }

        public Dept Dept { get; set;  }

        public override bool Equals(object entity)
        {
            if (entity != null && entity is Emp)
            {
                Emp that = (Emp)entity;
                if (EmpNo == 0 && that.EmpNo == 0)
                {
                    return this == that;
                }
                else
                {
                    return (EmpNo == that.EmpNo);
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = GetType().GetHashCode();
                result = (result * 397) ^ EmpNo.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

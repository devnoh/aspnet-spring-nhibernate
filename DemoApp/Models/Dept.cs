using Newtonsoft.Json;
using System.Text;

namespace DemoApp.Models
{
    public class Dept : BaseObject
    {
        public Dept()
        {
        }

        public int DeptNo { get; set; }

        public string DName { get; set; }

        public string Loc { get; set; }

        public override bool Equals(object entity)
        {
            if (entity != null && entity is Dept)
            {
                Dept that = (Dept)entity;
                if (DeptNo == 0 && that.DeptNo == 0)
                {
                    return this == that;
                }
                else
                {
                    return (DeptNo == that.DeptNo);
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = GetType().GetHashCode();
                result = (result * 397) ^ DeptNo.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

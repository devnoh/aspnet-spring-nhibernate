//
// BaseObject.cs
//
// Created by Sehwan Noh on 4/19/2013.
//

namespace DemoApp.Models
{
    public abstract class BaseObject
    {
        public override abstract bool Equals(object entity);

        public override abstract int GetHashCode();

        public override abstract string ToString();
    }
}
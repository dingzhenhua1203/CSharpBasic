using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.ListLib
{
    public class User : IEquatable<User>//继承IEquatable接口，实现Equals方法。List就可以使用Distinct去重  
    {
        public string name { get; set; }
        string address;

        public User(string _name, string _address)
        {
            name = _name;
            address = _address;
        }

        public override string ToString()
        {
            return string.Format("name:{0},\taddress:{1}", name, address);
        }

        public bool Equals(User other)
        {
            return this.name == other.name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }  
}

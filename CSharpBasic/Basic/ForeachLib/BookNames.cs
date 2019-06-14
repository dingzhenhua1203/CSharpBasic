using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.ForeachLib
{
    public class BookNames : IEnumerable<string>
    {
        //也可以实现IEnumerable,是普通集合，非泛型，需using System.Collections;
        private string[] _name;
        public string[] Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new BookNamesEumerator(_name);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new BookNamesEumerator(_name);
        }
    }
    public class BookNamesEumerator : IEnumerator<string>
    {
        private string[] _data;
        public BookNamesEumerator(string[] _key)
        { //构造函数要public才行
            _data = _key;
        }
        int index = -1;
        public string Current
        {
            get { return _data[index]; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= _data.Length)
                return false;
            return true;
        }


        public void Reset()
        {
            index = -1;
        }
    }
}

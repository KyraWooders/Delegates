using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class ArrayList
    {
        private object[] _list;
        public ArrayList()
        {
            _list = new object[0];
        }
        public virtual void Add(object value)
        {
            //Create a new array of Length + 1
            object[] newList = new object[_list.Length + 1];
            //put the values of the old array into the new array 
            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }
            //put the new value at the end of the new array 
            newList[newList.Length - 1] = value;
            
        }
        public virtual void Clear()
        {
            _list = new object[0];
        }
        public virtual object this[int index]
        {
            set
            {
                _list[index] = value;
            }
            get
            {
                return _list[index];
            }
        }
        public int Length
        {
            get
            {
                return _list.Length;
            }
        }
    }
}

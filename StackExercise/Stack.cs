using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
            else
            this._list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count < 0)
                throw new InvalidOperationException();
            else
            {
            var obj =  _list.ElementAt(_list.Count - 1);
            _list.RemoveAt(_list.Count -1);
            return obj;

            }
            
        }
        public void Clear()
        {
            _list.Clear();
        }
    }

}

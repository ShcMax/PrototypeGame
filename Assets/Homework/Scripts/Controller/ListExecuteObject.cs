using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Maze
{
    public class ListExecuteObject : IEnumerable, IEnumerator
    {
        private IExecute[] _interactiveObject;
        private int _index = -1;

        public object Current => _interactiveObject[_index];

        public int Lenght => _interactiveObject.Length;

        public IExecute this[int curr]
        {
            get => _interactiveObject[curr];
            private set => _interactiveObject[curr] = value;
        }

        public ListExecuteObject()
        {
            Traps[] TrapsObj = Object.FindObjectsOfType<Traps>();
            for(int i = 0; i < TrapsObj.Length; i++)
            {
                if(TrapsObj[i] is IExecute intObject)
                {
                    AddExecuteObject(intObject);
                }
            }

            Baffs[] BaffsObj = Object.FindObjectsOfType<Baffs>();
            for(int i = 0; i < BaffsObj.Length; i++)
            {
                if(BaffsObj[i] is IExecute intObject)
                {
                    AddExecuteObject(intObject);
                }
            }
        }

        public void AddExecuteObject(IExecute execute)
        {
            if(_interactiveObject == null)
            {
                _interactiveObject = new[] { execute };
                return;
            }
            Array.Resize(ref _interactiveObject, Lenght + 1);
            _interactiveObject[Lenght - 1] = execute;
        }

        public bool MoveNext()
        {
            if(_index == Lenght - 1)
            {
                return false;
            }
            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }        
    }
    
}

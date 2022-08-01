using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeekBrains
{
    public sealed class CList
    {
        
        private sealed class User
        {

            public string FirstName { get; }
            public string LastName { get; }

            public User(string firstName, string lastNme)
            {
                FirstName = firstName;
                LastName = lastNme;
            }
        }
        public void Main()
        {            
            List<int> numbers = new List<int>() {1,2,4,51,61,34,34,6,23,42,13,2,3,5,6,8,1,32,9,57,5,2,84,3,9,31};

            foreach(int i in numbers)
            {
                //Debug.Log(i);
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                int _count = 1;

                for(int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i].Equals(numbers[j]))
                    {                        
                        if (j == i) continue;
                        {                            
                            _count++;
                            numbers.RemoveAt(j);
                            j = 0;
                        }                        
                    }                    
                }
                Debug.Log($"{numbers[i]} - {_count} раз");
            }
        }
    }
}
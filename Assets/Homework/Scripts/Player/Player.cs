using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public class Player : Unit, ICloneable
    {

        int x = 10;
        int y = 20;

        string s1 = "Temp";
        string s2 = "Test";

        public override void Awake()
        {
            base.Awake();
            Swap(ref x, ref y);
            Swap(ref s1, ref s2); 
        }

        public override void Move(float x, float y, float z)
        {
            if (_rigidbody)
            {
                _rigidbody.AddForce(new Vector3(x, y, z) * _speed);
            }
        }

        public object Clone()
        {
            Player player = new Player();
            return player;
        }
        //public override void Jump()
        //{
        //    if(_rigidbody && Input.GetKey(KeyCode.Space))
        //    {
        //        _rigidbody.AddForce(Vector3.up * _forceJump, ForceMode.Force);
        //    }
        //}
        void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Player : Unit
    {

        public override void Awake()
        {
            base.Awake();
        }

        public override void Move(float x, float y, float z)
        {
            if (_rigidbody)
            {
                _rigidbody.AddForce(new Vector3(x, y, z) * _speed);
            }
        }
        //public override void Jump()
        //{
        //    if(_rigidbody && Input.GetKey(KeyCode.Space))
        //    {
        //        _rigidbody.AddForce(Vector3.up * _forceJump, ForceMode.Force);
        //    }
        //}
    }
}

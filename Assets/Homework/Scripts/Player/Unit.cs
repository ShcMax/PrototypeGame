using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Transform _transform;
        public Rigidbody _rigidbody;
        public float _speed = 5f;
        public int _health = 100;
        public bool _isDead;
        public float _forceJump;
        // Start is called before the first frame update
        public virtual void Awake()
        {
            _transform = GetComponent<Transform>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        public abstract void Move(float x, float y, float z);

        //public abstract void Jump();
    }
}

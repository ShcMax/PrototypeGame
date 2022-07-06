using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Transform _transform;
        public Rigidbody _rigidbody;
        public float _speed = 5f;
        private int health = 100;
        public bool _isDead;
        public float _forceJump;

        public int Health 
        {
            get 
            {
                return health;
            }

            set 
            { 
                if(health < 100 && health > -1)
                {
                    health = value;
                }
                else
                {
                    health = 100;
                }
            } 
        }

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

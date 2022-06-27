using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class FrozenTrap : Traps, IRotation, IFlick
    {
        private float _speedRotation;
        // Start is called before the first frame update

        private void Awake()
        {
            _speedRotation = Random.Range(5, 15);
        }
        void Start()
        {

        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public void Flick()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

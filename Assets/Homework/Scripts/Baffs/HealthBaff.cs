using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class HealthBaff : Baffs, IFly, IRotation
    {
        private float _highFly;
        private float _speedRotation;
        // Start is called before the first frame update
        private void Awake()
        {
            _highFly = Random.Range(1, 5);
            _speedRotation = Random.Range(10, 20);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _highFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Fly();
            Rotate();
        }
    }
}

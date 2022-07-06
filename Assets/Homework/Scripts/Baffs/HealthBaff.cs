using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class HealthBaff : Baffs, IFly, IRotation
    {        
        private float _speedRotation;     
        
        // Start is called before the first frame update
        public override void Awake()
        {
            base.Awake();            
            _speedRotation = Random.Range(10, 20);
            _heighFly = 2;
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heighFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        void Start()
        {

        }

        // Update is called once per frame
        public override void Update()
        {
            Fly();
            Rotate();
        }

        public override void Interaction()
        {

        }        
    }
}

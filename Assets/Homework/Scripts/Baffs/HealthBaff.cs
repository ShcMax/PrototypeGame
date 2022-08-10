using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Maze
{
    
    public class HealthBaff : Baffs, IFly, IRotation
    {
        //public PlayerData _healthData;
        //private ISaveData _data;

        public event Action<string> Fin = delegate (string str) { };
        public event Action<int> AddPoints = delegate (int i) { };

        private string _str;        
        
        private int _point;
        private float _speedRotation;

        private GetBonus _getBonus;

        public sealed class GetBonus
        {
            private int _pointBonus = 1;
            private float _speedBonus = Random.Range(10, 20);

            public int PointBonus { get => _pointBonus; set => _pointBonus = value; }
            public float SpeedBonus { get => _speedBonus; set => _speedBonus = value; }

            public (int pointBonus, float speedBonus) Get()
            {
                return (PointBonus, SpeedBonus);
            } 
        }       

        public int Point { get => _point; set => _point = Point; }
        public float SpeedRotation { get => _speedRotation; set => _speedRotation = SpeedRotation; }

        // Start is called before the first frame update
        public override void Awake()
        {
            base.Awake();

            _getBonus = new GetBonus();

            SpeedRotation = _getBonus.SpeedBonus;
            _heighFly = 2;
            Point = _getBonus.PointBonus;
        }               

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heighFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * SpeedRotation), Space.World);
        }    

        public void GetBaff()
        {            
            GetBonus get = new GetBonus();
            (int pointBonus, float speedBonus) bonus = (get.PointBonus, get.SpeedBonus);
            Debug.Log($" получено очков {bonus.pointBonus} / скорость вращения бонуса {bonus.speedBonus}");
        }
        
        

        // Update is called once per frame
        public override void Update()
        {
            Fly();
            Rotate();
        }

        protected override void Interaction()
        {
            AddPoints?.Invoke(Point);
            Fin?.Invoke(_str);
        }        
    }
}

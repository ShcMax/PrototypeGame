using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Maze
{
    public struct PlayerData
    {
        public string Name;
        public Vector3 Position;
        public Quaternion Rotation;        

        public PlayerData (HealthBaff healthBaff)
        {
            Name = healthBaff.name;
            Position = healthBaff.transform.position;
            Rotation = healthBaff.transform.rotation;            
        }

    }
    public class HealthBaff : Baffs, IFly, IRotation
    {
        public PlayerData _healthData;
        private ISaveData _data;

        public event Action<string> Fin = delegate (string str) { };
        public event Action<int> AddPoints = delegate (int i) { };
        private string _str;
        private int _point;
        private float _speedRotation;     
        
        // Start is called before the first frame update
        public override void Awake()
        {
            base.Awake();            
            _speedRotation = Random.Range(10, 20);
            _heighFly = 2;
            _point = 1;

            _data = new JSonData();
            _healthData = new PlayerData(this);
            _data.SaveData(_healthData);

            PlayerData temp = new PlayerData();
            temp = _data.Load();

            Debug.Log(temp.Name);
            Debug.Log(temp.Position);
            Debug.Log(temp.Rotation);
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heighFly), transform.position.z);
        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }       

        // Update is called once per frame
        public override void Update()
        {
            Fly();
            Rotate();
        }

        protected override void Interaction()
        {
            AddPoints?.Invoke(_point);
            Fin?.Invoke(_str);
        }        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Maze
{
    public struct PlayerData
    {
        public string Name;
        public Vector3 Position;
        public Quaternion Rotation;
        public int Health;
        public bool PlayerDead;

        public PlayerData(Player player)
        {
            Name = player.name;
            Position = player.transform.position;
            Rotation = player.transform.rotation;
            Health = player.Health;
            PlayerDead = player._isDead;
        }
    }
    public class Player : Unit
    {
        public PlayerData _playerData;
        private ISaveData _data;

        delegate void Message();
        Message _message;

        public Transform PlayerDot;

        public override void Awake()
        {
            base.Awake();
            Health = 100;


            _data = new XMLData();
            _playerData = new PlayerData(this);
            _data.SaveData(_playerData);
            PlayerData temp = new PlayerData();
            temp = _data.Load();

            //Debug.Log(temp.Health);
            //Debug.Log(temp.Position);
            //Debug.Log(temp.Rotation);
            //Debug.Log(temp.PlayerDead);
        }
        
        public override void Move(float x, float y, float z)
        {
            PlayerDot.position = new Vector3(transform.position.x, PlayerDot.position.y, transform.position.z);
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

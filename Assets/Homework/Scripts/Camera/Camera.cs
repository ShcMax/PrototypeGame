using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class CameraController : IExecute
    {
        private Transform _player;
        private Transform _camera;
        private Vector3 _offset;
        public CameraController(Transform player, Transform mainC)
        {
            _player = player;
            _camera = mainC;
            _offset = _camera.position - _player.position;
            _camera.LookAt(_player);
        }     
       
        public void Update()
        {
            //Vector3 relat = player.transform.position - transform.position;
            //Quaternion rot = Quaternion.LookRotation(relat);
            //transform.rotation = rot;
            _camera.position = _player.position + _offset;
        }        
    }
}
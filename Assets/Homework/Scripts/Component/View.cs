using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TestMVC
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private Collider _collider;
        [SerializeField] private Rigidbody _rb;

        public Transform Transform { get => _transform; set => _transform = value; }
        public Collider Collider { get => _collider; set => _collider = value; }
        public Rigidbody Rb { get => _rb; set => _rb = value; }
        public Action<Collider, int, Transform> OnLevelObjectContact { get; set; }


        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name);

            Collider LevelObject = other;

            OnLevelObjectContact?.Invoke(LevelObject, 13, Transform);
        }

    }
}
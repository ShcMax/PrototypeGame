using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Baffs : MonoBehaviour, IExecute
    {
        private bool _isInteractable;
        private Color _color;
        private Renderer _renderer;
        private Collider _collider;
        public float _heighFly;

        public bool IsInteractable 
        { 
            get => _isInteractable;

            set 
            {
                _isInteractable = value;
                _renderer.enabled = value;
                _collider.enabled = value;
            }             
        }

        public virtual void Awake()
        {            
            _renderer = GetComponent<Renderer>();
            _collider = GetComponent<Collider>();
            IsInteractable = true;
            _color = Random.ColorHSV();

            _renderer.sharedMaterial.color = _color;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(IsInteractable || other.CompareTag("Player"))
            {
                Interaction();
                IsInteractable = false;
            }
        }

        public abstract void Interaction();
        public abstract void Update();        
    }
}

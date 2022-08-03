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

        public Color Color { get => _color; set => _color = value; }

        public virtual void Awake()
        {            
            _renderer = GetComponent<Renderer>();
            _collider = GetComponent<Collider>();
            IsInteractable = true;
            Color = Random.ColorHSV();

            _renderer.sharedMaterial.color = Color;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(IsInteractable || other.CompareTag("Player"))
            {
                Interaction();
                IsInteractable = false;
            }
        }

        protected abstract void Interaction();
        public abstract void Update();        
    }
}

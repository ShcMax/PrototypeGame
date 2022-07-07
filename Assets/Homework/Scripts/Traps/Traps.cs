using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public abstract class Traps : MonoBehaviour, IExecute
    {
        private bool _isInteractable;
        protected private Color _color;
        private Renderer _renderer;
        private Collider _collider;
        public float _heighFly;

        public bool IsInteractable
        {
            get => _isInteractable;

            set
            {
                _isInteractable = value;
                TrapsRenderer.enabled = value;
                _collider.enabled = value;
            }
        }

        public Renderer TrapsRenderer 
        { 
            get => _renderer; 

            set => _renderer = value; 
        }

        public virtual void Awake()
        {
            TrapsRenderer = GetComponent<Renderer>();
            _collider = GetComponent<Collider>();
            IsInteractable = true;
            _color = Random.ColorHSV();

            TrapsRenderer.sharedMaterial.color = _color;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (IsInteractable || other.CompareTag("Player"))
            {
                Interaction();
                IsInteractable = false;
            }
        }

        protected abstract void Interaction();
        public abstract void Update();
    }
}

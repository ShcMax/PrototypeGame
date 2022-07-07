using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Maze
{
    public class FireTrap : Traps, IFlick, IFly
    {
        private Material _material;
        public event Action<string, Color> OnGameOver = delegate (string str, Color color) { };

        public override void Awake()
        {
            base.Awake();
            _heighFly = 3f;
            _material = TrapsRenderer.material;
        }

        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _heighFly), transform.position.z);
        }

        public void Flick()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public override void Update()
        {
            Fly();
            Flick();
        }
        protected override void Interaction()
        {
            OnGameOver?.Invoke(gameObject.name, _color);
        }
    }
}

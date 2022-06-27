using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController _InputController;
        [SerializeField] private Unit _player;
        // Update is called once per frame
        private void Awake()
        {
            _InputController = new InputController(_player);
        }
        void Update()
        {
            _InputController.Update();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {        
        private ListExecuteObject _interactiveObject;
        private InputController _InputController;
        IEnumerator etr;
        [SerializeField] private Unit _player;
        // Update is called once per frame
        private void Awake()
        {           
            _interactiveObject = new ListExecuteObject();
            _InputController = new InputController(_player);
            _interactiveObject.AddExecuteObject(_InputController);
            etr = _interactiveObject.GetEnumerator();
        }
        void Update()
        {
           for (int i = 0; i < _interactiveObject.Lenght; i++)
            {
                if(_interactiveObject[i] == null)
                {
                    continue;
                }
                _interactiveObject[i].Update();
            }
        }
    }
}

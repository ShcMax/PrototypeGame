using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private CameraController _camera;
        private ListExecuteObject _interactiveObject;
        private InputController _InputController;              
        [SerializeField] private Unit _player;
        
        private void Awake()
        {           
            _interactiveObject = new ListExecuteObject();
            _InputController = new InputController(_player);            
            _camera = new CameraController(_player.transform, Camera.main.transform);

            _interactiveObject.AddExecuteObject(_camera);
            _interactiveObject.AddExecuteObject(_InputController);
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

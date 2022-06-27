using UnityEngine;

namespace Maze
{
    public class InputController
    {
        private readonly Unit _player;
        private float horizontal;
        private float vertical;

        public InputController(Unit player)
        {
            _player = player;
        }

        // Update is called once per frame
        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            _player.Move(horizontal, 0f, vertical);
            //_player.Jump();
        }
    }
}

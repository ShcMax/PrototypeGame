using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeekBrains;

namespace TestMVC
{    

    public class Main : MonoBehaviour
    {

        [SerializeField] private View _player;
        [SerializeField] private View _trigger;

        private Controller _controller;
        private CList List;

        private void Awake()
        {
           // _controller = new Controller(_player, _trigger);

            List = new CList();
            List.Main();
        }

        private void Update()
        {
            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestMVC
{

    public class Controller : MonoBehaviour
    {

        private View _playerView;
        private View _triggerView;
        private Transform _playerT;

        public Controller(View playerView, View triggerView)
        {
            _playerView = playerView;
            _triggerView = triggerView;
            _playerT = _playerView.Transform;

            _triggerView.OnLevelObjectContact += ControllerRecieveAction;
        }

        private void ControllerRecieveAction(Collider contactView, int val, Transform objectT)
        {
            Debug.Log("Обработчик события: Имя объекта в триггере" + contactView.name);
            GameObject.Destroy(contactView.gameObject);
        }

    }
}

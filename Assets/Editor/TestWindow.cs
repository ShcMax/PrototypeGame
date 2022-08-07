using UnityEngine;
using UnityEditor;


namespace Maze
{
    public class TestWindow: EditorWindow
    {        
        public static GameObject _object;
        public string _nameObject = "Объект";
        public bool _check = true;
        public int _slide = 1;
        public string _text;
        
        

        private void OnGUI()
        {
            GUILayout.Label("Настройки", EditorStyles.boldLabel);
            _object = EditorGUILayout.ObjectField("Выберите объект", _object, typeof(GameObject), true) as GameObject;
            _nameObject = EditorGUILayout.TextField("Имя", _nameObject);
            _check = EditorGUILayout.Toggle("Check", _check);
            _slide = EditorGUILayout.IntSlider("Slide", _slide, 1, 10);
            var button = GUILayout.Button("Button");
            if (button)
            {               
                _check = false;
            }

        }
    }

}
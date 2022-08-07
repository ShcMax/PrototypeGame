using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Maze
{
    [CustomEditor(typeof(TestScript))]
    public class Script_1 : UnityEditor.Editor
    {
        private bool _isPressButtonOk;

        public override void OnInspectorGUI()
        {
            TestScript test = (TestScript)target;

            test.count = EditorGUILayout.IntSlider(test.count, 10, 50);
            test.offset = EditorGUILayout.IntSlider(test.offset, 1, 5);
            test.obj = EditorGUILayout.ObjectField("Object", test.obj, typeof(GameObject), false) as GameObject;

            var isPressButton = GUILayout.Button("Create", EditorStyles.miniButtonLeft);
            _isPressButtonOk = GUILayout.Toggle(_isPressButtonOk, "OK");

            if (isPressButton)
            {
                test.CreateObj();
                isPressButton = true;
            }
            if (isPressButton)
            {
                test.Test = EditorGUILayout.Slider(test.Test, 10, 50);
                EditorGUILayout.HelpBox("Button is Pressed", MessageType.Warning);

                var isPressAddButton = GUILayout.Button("Add Component", EditorStyles.miniButtonLeft);
                var isPressRemoveButton = GUILayout.Button("Remove Component", EditorStyles.miniButtonLeft);

                if (isPressAddButton)
                {
                    test.AddComponent();
                }
                if (isPressRemoveButton)
                {
                    test.RemoveComponent();
                }
            }
        }
    }
}
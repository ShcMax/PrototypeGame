using UnityEngine;
using UnityEditor;

namespace Maze
{

    public class MyWindow
    {
        [MenuItem("My Window/ MainMenu")]

        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(TestWindow), false, "Homework");
        } 
    }

}
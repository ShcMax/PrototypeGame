using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

namespace Maze
{
    public class UIDisplayWinGame
    {
        private Text _winGameLabel;

        public UIDisplayWinGame(Text winGameText)
        {
            _winGameLabel = winGameText;
            _winGameLabel.text = String.Empty;
        }

        public void DisplayWin(string game)
        {
            _winGameLabel.text = $"Win";
        }
        
    }
}
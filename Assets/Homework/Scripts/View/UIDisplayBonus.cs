using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class UIDisplayBonus
    {
        private Text _pointsLabel;

        public UIDisplayBonus(Text pointsLabel)
        {
            _pointsLabel = pointsLabel;
            _pointsLabel.text = String.Empty;
        }

        public void Display(int value)
        {
            _pointsLabel.text = $"Bonus: {value}";
        }
    }
}
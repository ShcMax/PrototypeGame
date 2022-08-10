using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private UIDisplayBonus _displayBonus;
        [SerializeField] private Text _pointLabel;
        private UIDisplayGameOver _displayGameOver;
        [SerializeField] private Text _gameOver;
        [SerializeField] private Button _restartButton;
        private UIDisplayWinGame _displayWinGame;
        [SerializeField] private Text _winLabel;


        private HealthBaff _baff;
        private CameraController _camera;
        private ListExecuteObject _interactiveObject;
        private InputController _InputController;              
        [SerializeField] private Unit _player;

        private int _bonusCount;        

        
        private void Awake()
        {
            _baff = new HealthBaff();

            Time.timeScale = 1;
            
            _interactiveObject = new ListExecuteObject();

            _InputController = new InputController(_player);            
            _camera = new CameraController(_player.transform, Camera.main.transform);

            _interactiveObject.AddExecuteObject(_camera);
            _interactiveObject.AddExecuteObject(_InputController);

            _displayBonus = new UIDisplayBonus(_pointLabel);
            _displayGameOver = new UIDisplayGameOver(_gameOver);
            _displayWinGame = new UIDisplayWinGame(_winLabel);

            _restartButton.onClick.AddListener(RestartGame);
            _restartButton.gameObject.SetActive(false);


            foreach(var item in _interactiveObject)
            {
                if(item is FireTrap fireTrap)
                {
                    fireTrap.OnGameOver += GameOver;
                    fireTrap.OnGameOver += _displayGameOver.GameOver;
                }
                if(item is HealthBaff healthBaff)
                {
                    healthBaff.AddPoints += AddPoint;                    
                }
                
            }
        }

        private void AddPoint(int value)
        {
            _bonusCount += value;
            _displayBonus.Display(_bonusCount);
            _baff.GetBaff();
        }

        private void GameOver(string value, Color color)
        {
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(0);            
        }

        private void WinGame(string win)
        {
            _displayWinGame.DisplayWin("Win");
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
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

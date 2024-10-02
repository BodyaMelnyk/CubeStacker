using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(RestartButtonClick);
        _exitButton.onClick.AddListener(ExitButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(RestartButtonClick);
        _exitButton.onClick.RemoveListener(ExitButtonClick);
    }

    private void RestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    private void ExitButtonClick()
    {
        Application.Quit();
    }
}

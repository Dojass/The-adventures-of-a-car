using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private int levelUnlock;
    public Button[] buttons;

    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("LevelComplete", 1);

        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].interactable = false; 
        }

        for (int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }

   public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void RestartGameplay() {
        PlayerPrefs.DeleteAll();

        for (int i = 1; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
    }

    public void ReturnToMenu() {
        SceneManager.LoadScene(4);
    }
}

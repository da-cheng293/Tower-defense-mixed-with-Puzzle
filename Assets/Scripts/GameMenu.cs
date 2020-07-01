﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

    public void OnStartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OnStartGame2()
    {
        SceneManager.LoadScene(3);
    }

    public void OnRules()
    {
        SceneManager.LoadScene(2);
    }
    public void OnExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

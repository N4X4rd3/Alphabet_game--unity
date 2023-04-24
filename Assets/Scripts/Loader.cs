using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public static Loader Instance;

    public void Awake()
    {
        Instance = this;
    }

    public enum Scenes
    {
        MainMenu,
        LevelSelector,
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;

    public void Awake()
    {
        Instance = this;
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
    }
}

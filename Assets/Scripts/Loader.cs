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

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Learn()
    {
        SceneManager.LoadScene(2);
    }

    public void Draw()
    {
        SceneManager.LoadScene(4);
    }
    public void Find()
    {
        SceneManager.LoadScene(3);
    }
}

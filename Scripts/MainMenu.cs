using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int Score;
    public void LoadGame()
    {
        Score=0;
        SceneManager.LoadScene(1);
    }

}

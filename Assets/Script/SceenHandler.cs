using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenHandler : MonoBehaviour
{
    GameManager gameManager = new();

    public void Game960()
    {
        SceneManager.LoadScene("Main");
       // DontDestroyOnLoad(this.gameObject);
    }

    public void BaseGame()
    {
        SceneManager.LoadScene("Main");

    }
}

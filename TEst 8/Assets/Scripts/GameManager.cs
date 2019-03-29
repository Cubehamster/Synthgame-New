using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour

    
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject GameOverScreen;
    public GameObject Player;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            GameOverScreen.SetActive(true);
            Invoke("Restart", restartDelay);
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
    }
    
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //StartCoroutine(Restart(restartDelay));    meore varianti restartistvis
        }

        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // meore varianti restartistvis
    //static IEnumerator Restart(float restartDelay = 2f)
    //{
    //yield return new WaitForSeconds(restartDelay);
    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}


    public void CompletedLevel()
    {
        completeLevelUI.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; // We need to use this when we use a different scene or reload a scene

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EngGame ()
    {
        // This checks that if the boolean is true, then the game won't be restarted again
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // This calls the Restart function after a __ second delay. 
            Invoke("Restart", restartDelay);
        }
    }
    
    void Restart ()
    {
        // This reloads the (current scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

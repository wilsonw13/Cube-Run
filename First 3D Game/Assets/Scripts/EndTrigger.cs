using UnityEngine;

public class EndTrigger : MonoBehaviour {
    
    public GameManager gameManager;

    void OnTriggerEnter () {
        // Actives the function in the "gameManager" script
            gameManager.CompleteLevel();
    }
}

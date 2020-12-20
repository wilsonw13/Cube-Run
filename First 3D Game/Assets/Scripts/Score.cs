using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player; // We need to reference the player's z value for the score
    public Text scoreText; // We need to put a value into this text

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); // Taking the Z value of a player and truncating the decimal off
    }
}
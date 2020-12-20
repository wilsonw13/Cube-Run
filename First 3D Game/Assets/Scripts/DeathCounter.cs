using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{
    public Text deathCounterText; // We need to put a value into this text
                                  // Update is called once per frame
    int deaths = 0;
    void Update()
    {
        deathCounterText.text = "Death Counter:";
    }
}

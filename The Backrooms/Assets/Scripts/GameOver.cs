using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            gameOver = true;
            Time.timeScale = 0f;
        }
    }
}

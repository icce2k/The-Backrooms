using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1f;
    }

    public void OnTriggerEnter3D(Collider collision)
    {
        if (collision.tag == "Player")
        {
            gameOver = true;
            Time.timeScale = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (other.gameObject.tag == "Player" && playerInventory != null)
        {
            playerInventory.Collected();
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Component doorcollider;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.Collected();
            gameObject.SetActive(false);
            doorcollider.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

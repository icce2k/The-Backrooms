using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        PlayerInventory inventory = collider.GetComponent<PlayerInventory>();

        if (collider.gameObject.tag == "Player" && inventory.numberOfKeys > 0)
        {
            print("test");
            Destroy(gameObject);
        }
    }
}

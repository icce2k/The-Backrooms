using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animation hingehere;
    public Component doorcollider;

    private void OnTriggerStay(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (Input.GetKey(KeyCode.E))
        {
            hingehere.Play();
            doorcollider.GetComponent<BoxCollider>().enabled = false;
        }
    }
}

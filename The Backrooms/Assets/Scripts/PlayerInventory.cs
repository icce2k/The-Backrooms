using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int numberOfKeys { get; set; }

    public void Collected()
    {
        numberOfKeys++;
    }
}

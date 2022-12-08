using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate2 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && GameVariables.keyCount>0+2)
        {
            GameVariables.keyCount--;
            Destroy(gameObject);
        }
    }
}

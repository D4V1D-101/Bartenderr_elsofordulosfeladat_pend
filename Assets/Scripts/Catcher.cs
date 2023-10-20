using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Toxic" || target.tag == "Water")
        {
            target.gameObject.SetActive(false);
        }
    }

}

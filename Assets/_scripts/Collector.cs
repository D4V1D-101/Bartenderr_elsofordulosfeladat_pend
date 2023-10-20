using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "toxin" || target.tag == "water") target.gameObject.SetActive(false);
    }
}

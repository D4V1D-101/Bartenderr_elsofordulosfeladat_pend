using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsc : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}

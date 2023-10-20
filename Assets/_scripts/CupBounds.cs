using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupBounds : MonoBehaviour
{


    public float Minx,Maxx;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        Minx = -coor.x + 0.3f;
        Maxx = coor.x - 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        if (temp.x>Maxx)
        {
            temp.x = Maxx;
        }
        if (temp.x < Minx)
        {
            temp.x = Minx;
        }
        transform.position = temp;

    }
}

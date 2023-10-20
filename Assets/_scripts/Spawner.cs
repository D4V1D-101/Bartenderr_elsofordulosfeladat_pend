using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    private GameObject[] drops;
    private BoxCollider2D col;

    float x1, x2;


    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider2D>();

         x1 = transform.position.x - col.bounds.size.x / 2f;
         x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    // Update is called once per frame
    void Start  ()
    {
        StartCoroutine(SpawnDrop(1f));

        IEnumerator SpawnDrop(float time)
        {
            yield return new WaitForSecondsRealtime(time);

            

            Vector3 temp = transform.position;
            temp.x = Random.Range(x1, x2);

            Instantiate(drops[Random.RandomRange(0, drops.Length)], temp, Quaternion.identity);

            StartCoroutine(SpawnDrop(Random.Range(1f, 2f)));
        }
    }
}

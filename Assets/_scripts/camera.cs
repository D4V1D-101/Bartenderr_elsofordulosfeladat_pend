using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private  Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y, 0);
        Vector3 bottomLeft = _camera.ViewportToWorldPoint(Vector3.zero) * 100;
        Vector3 topRight = _camera.ViewportToWorldPoint(new Vector3(_camera.rect.width, _camera.rect.height)) * 100;
        Vector3 screenSize = topRight - bottomLeft;
        float screenRatio = screenSize.x / screenSize.y;
        float desiredRatio = transform.localScale.x / transform.localScale.y;

        if (screenRatio > desiredRatio)
        {
                float height = screenSize.y;
                transform.localScale = new Vector3(height * desiredRatio, height);
        }
        else
        {
            float width = screenSize.x;
            transform.localScale = new Vector3(width, width / desiredRatio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

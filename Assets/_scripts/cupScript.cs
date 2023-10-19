using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupScript : MonoBehaviour
{
    private bool isDragging = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isDragging = true;
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                Vector2 touchDeltaPosition = touch.deltaPosition;
                MoveCup(touchDeltaPosition.normalized);
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isDragging = false;
            }
        }
        else if (isDragging && Input.GetMouseButton(0))
        {
            Vector2 touchDeltaPosition = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            MoveCup(touchDeltaPosition.normalized);
        }
    }

    void MoveCup(Vector2 direction)
    {
        // You can adjust the movement speed as needed
        float moveSpeed = 5f;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}

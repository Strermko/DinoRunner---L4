using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 0.3f;

    void FixedUpdate()
    {
        transform.localPosition = new Vector2(transform.localPosition.x - speed / 100, transform.localPosition.y);

        if(transform.localPosition.x <= -10){
            transform.localPosition = new Vector2(10, transform.localPosition.y);
        }
    }
}

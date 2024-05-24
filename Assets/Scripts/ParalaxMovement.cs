using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParalaxMovement : MonoBehaviour
{
    [SerializeField] float limitPosition;
    [SerializeField] float speed;

    private Vector2 startPosition;

    void Start()
    {
        startPosition = transform.localPosition;
    }

    void FixedUpdate()
    {
        transform.localPosition = new Vector2(transform.localPosition.x - speed / 100, transform.localPosition.y);
        
        if(transform.localPosition.x <= limitPosition){
            transform.localPosition = startPosition; 
        }
    }
}

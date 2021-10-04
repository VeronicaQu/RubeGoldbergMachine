using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() 
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Space)){

           rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
    }


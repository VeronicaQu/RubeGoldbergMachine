using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Camera ca;
    public Camera ca2; 
    // Start is called before the first frame update
    public bool Turn;
    void Start()
    {
        Turn = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
            if (collision.CompareTag("Player")){
                Turn = true; 

            }

    }
    void Update()
    {
        if(ca.enabled == true){
          if(Turn){
              ca.enabled = false;
              ca2.enabled = true;
          }
        }
        else {
            Turn = false;
        }


        }
    }


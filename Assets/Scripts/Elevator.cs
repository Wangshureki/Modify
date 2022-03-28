using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public GameObject AnimeObject;
    public GameObject ThisTrigger;

    public bool Action = false;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
          
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
   
        Action = false;
    }
    void Update()
    {
   
            if (Action == true)
            {
         
                AnimeObject.GetComponent<Animator>().Play("Down");
             
                ThisTrigger.SetActive(false);
                Action = false;
            }
        }
    }

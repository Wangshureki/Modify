using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    // public GameObject Redlight1;
    //public GameObject Redlight2;
    // public GameObject Redlight2;
    // public GameObject Redlight3;
    // public GameObject Redlight4;
    // public GameObject Flashlight;
    public GameObject Button;
    // public GameObject fivesec;
    // public GameObject RedDirection;
    //public GameObject GreenDirection;


    // Start is called before the first frame update
    private void Start()
    {
        // Redlight1.SetActive(true);
        // Redlight2.SetActive(true);
        // Redlight3.SetActive(true);
        //// Redlight4.SetActive(true);
        Button.SetActive(true);
        // Flashlight.SetActive(false);
        // fivesec.SetActive(false);
        //RedDirection.SetActive(true);
        //GreenDirection.SetActive(false);




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            //Redlight1.SetActive(false);
            //Redlight2.SetActive(false);
            //Redlight3.SetActive(false);
            // Redlight4.SetActive(false);
            Button.SetActive(false);
            // Flashlight.SetActive(true);
            // fivesec.SetActive(true);
            // RedDirection.SetActive(false);
            //GreenDirection.SetActive(true);

            //fivesec.GetComponent<Animator>().Play("Countdown");

            //Invoke("Disappear", 5.0f);
        }
    }
    //private void Disappear()
    //{
    //Redlight1.SetActive(true);
    //Redlight2.SetActive(true);
    //Redlight3.SetActive(true);
    //Redlight4.SetActive(true);
    //Flashlight.SetActive(false);
    //fivesec.SetActive(false);
    //RedDirection.SetActive(true);
    //GreenDirection.SetActive(false);
    //}
}

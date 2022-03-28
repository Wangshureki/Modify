using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public GameObject PickUpUI;
    public GameObject Controller;
    public GameObject ControllerPanel;
    public GameObject ThisTrigger;
    public GameObject ConforimSpacebar;
    public GameObject Conforim;
    public GameObject Button;

    public bool Action = false;
    private void Start()
    {
        PickUpUI.SetActive(false);
        ControllerPanel.SetActive(false);
        ConforimSpacebar.SetActive(false);
        Conforim.SetActive(false);
        Button.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            PickUpUI.SetActive(true);
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        PickUpUI.SetActive(false);
        Action = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                PickUpUI.SetActive(false);
                Controller.SetActive(false);
                ThisTrigger.SetActive(false);
                ControllerPanel.SetActive(true);
                ConforimSpacebar.SetActive(true);
                Conforim.SetActive(true);
                Action = false;
                Button.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ControllerPanel.SetActive(false);
                    ConforimSpacebar.SetActive(false);
                    Conforim.SetActive(false);
                }
            }
        }
    }
}


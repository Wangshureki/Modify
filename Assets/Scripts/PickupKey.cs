using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject PickUpUI;
    public GameObject Key;
    public GameObject KeyPanel;
    public GameObject ThisTrigger;
    public GameObject ConforimSpacebar;
    public GameObject Conforim;

    public bool Action = false;
    private void Start()
    {
        PickUpUI.SetActive(false);
        KeyPanel.SetActive(false);
        ConforimSpacebar.SetActive(false);
        Conforim.SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Action == true)
            {
                PickUpUI.SetActive(false);
                Key.SetActive(false);
                ThisTrigger.SetActive(false);
                KeyPanel.SetActive(true);
                ConforimSpacebar.SetActive(true);
                Conforim.SetActive(true);
                Action = false;

                if (Input.GetKeyDown(KeyCode.Space)){
                    KeyPanel.SetActive(false);
                    ConforimSpacebar.SetActive(false);
                    Conforim.SetActive(false);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageControl : MonoBehaviour
{
    public GameObject Bar;
    public GameObject Key;
    public GameObject Button;
    public GameObject Spacebar;
    public GameObject SpacebarText;

    public GameObject Notification;
    public GameObject VoiceMessage;
    public GameObject ThisTrigger;
   // public GameObject BlaclBlock;
   // public GameObject BlaclBlock1;

    public bool Action = false;
    private void Start()
    {
        Bar.SetActive(true);
        Spacebar.SetActive(true);
        SpacebarText.SetActive(true);
        Notification.SetActive(true);
        VoiceMessage.SetActive(false);
    
        Button.SetActive(false);
      


    }
    // Start is called before the first frame update



    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Notification.SetActive(false);
            VoiceMessage.SetActive(true);
            Spacebar.SetActive(false);
            SpacebarText.SetActive(false);
            Invoke("Space", 2.0f);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            VoiceMessage.GetComponent<Animator>().Play("MessageOne");
            Spacebar.SetActive(false);
            SpacebarText.SetActive(false);
            Invoke("Space", 7.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            VoiceMessage.GetComponent<Animator>().Play("MessageTwo");
            Spacebar.SetActive(false);
            SpacebarText.SetActive(false);
           // BlaclBlock.GetComponent<Animator>().Play("BlackBlock_Disappear");
           // BlaclBlock.GetComponent<Animator>().Play("BlackBlock_Disappear1");
            

        }
    }
    private void Space()
    {Spacebar.SetActive(true);
        SpacebarText.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBigDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public GameObject AnimeObject2;
    public GameObject ThisTrigger;
    public GameObject SecurityCheck;
    public GameObject Bar;
    public GameObject Key;
    public GameObject Button;
    public bool Action = false;
    private void Start()
    {
        Instruction.SetActive(false);
        SecurityCheck.SetActive(false);
        Bar.SetActive(true); 
        Key.SetActive(true); 
        Button.SetActive(true);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("Opening");
                AnimeObject2.GetComponent<Animator>().Play("Opening");
                ThisTrigger.SetActive(false);
                Action = false;
                SecurityCheck.SetActive(true);
                SecurityCheck.GetComponent<Animator>().Play("3secAnimation");
                Invoke("UIAppear", 3.0f);
                Bar.SetActive(false);
                Key.SetActive(false);
                Button.SetActive(false);
            }
        }
    }

    private void UIAppear()
    {

        Bar.gameObject.SetActive(true);
        Key.SetActive(true);
        Button.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public GameObject AnimeObject2;
    public GameObject ThisTrigger;
    public bool Action = false;
    private void Start()
    {
        Instruction.SetActive(false);
    }
    void OnTriggerEnter (Collider collision)
    { if (collision.transform.tag =="Player")
        { Instruction.SetActive(true);
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
            }
        }
    } 
                }
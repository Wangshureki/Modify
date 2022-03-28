using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gif : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animateImageObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animateImageObj.sprite = animatedImages[(int)(Time.time * 20) % animatedImages.Length];
    }
}

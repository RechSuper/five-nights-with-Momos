using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public Vector3 mouse;
    public float percentage;
    public bool isleft;

    public float vb = Screen.width;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        percentage = Mathf.Floor(mouse.x / Screen.width);
        if (percentage <= 50)
        {
            isleft = true;
        } else 
        {
            isleft = false;
        }
    }
}

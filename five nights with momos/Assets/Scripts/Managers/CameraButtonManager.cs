using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraButtonManager : MonoBehaviour
{
    public static bool isPanel = false;
    public GameObject CameraPanel;
    public GameObject CameraButton;

    public Sprite ButtonCamOn;
    public Sprite ButtonCamOff;

    Image image;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleCamera()
    {
        if (isPanel == false)
        {
            isPanel = true;
            CameraPanel.SetActive(true);
            CameraButton.GetComponent<Image>().sprite = ButtonCamOn;

        }else
        {
            isPanel = false;
            CameraPanel.SetActive(false);
            CameraButton.GetComponent<Image>().sprite = ButtonCamOff;
        }
    }
}

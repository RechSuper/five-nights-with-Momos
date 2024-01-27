using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static string[] names = {"Show Stage", "OXXO Mini-Market", "Restrooms", "Playground", "Arcade Zone", "Kitchen", "Suply Room", "West Hall", "East Hall", "Placeholder"};
    public GameObject[] cameras;
    public static int selectedCamera = 0;
    public int ibuhb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ibuhb = selectedCamera;
        if (CameraButtonManager.isPanel == false)
        {
            cameras[selectedCamera].SetActive(false);
        }else
        {
            CameraSwitch(selectedCamera);
        }
    }

    public void CameraSwitch(int camNum)
    {
        for (int i = 0; i < 9; i++)
        {
            cameras[i].SetActive(false);
        }
        cameras[camNum].SetActive(true);
        selectedCamera = camNum;
    }   
}
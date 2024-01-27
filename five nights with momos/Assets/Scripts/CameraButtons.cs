using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraButtons : MonoBehaviour
{
    public Sprite activeSprite;
    public Sprite normalSprite;
    bool repeat;
    [SerializeField] int cameraNum;
    [SerializeField] CameraManager CM;
    // Start is called before the first frame update
    void OnEnable()
    {
        repeat = true;
        if (CameraManager.selectedCamera != cameraNum)
        {
        this.GetComponent<Image>().sprite = normalSprite;
        }
        Debug.LogWarning("cataplum");
    }

    // Update is called once per frame
    void Update()
    {
            if (CameraManager.selectedCamera == cameraNum)
            {
                if (CameraButtonManager.isPanel == true && repeat == true)
                {
                    StartCoroutine(Flashing());
                }
            }else
            {
                StopCoroutine(Flashing());
                repeat = true;
                this.GetComponent<Image>().sprite = normalSprite;
            }
    }

    IEnumerator Flashing()
    {
        repeat = false;
        this.GetComponent<Image>().sprite = activeSprite;
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Image>().sprite = normalSprite;
        yield return new WaitForSeconds(0.5f);
        repeat = true;
    }
}

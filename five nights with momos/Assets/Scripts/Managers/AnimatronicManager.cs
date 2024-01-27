using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class AnimatronicManager : MonoBehaviour
{
    [Header("el pepe stuff")]
    public int[] elpepeArray = {0, 1, 2, 8, 10, 11};
    public int elpepeAI;
    public int elpepeRandom;
    public int elpepePos = -1;

    [Header("ete sech stuff")]
    public int[] etesechArray = {0, 4, 5, 6, 7, 9, 11};
    public int etesechAI;
    public int etesechRandom;
    public int etesechPos = -1;

    [Header("Camaras")]
    public int elpepeCam;
    public int etesechCam;

    [Header("Other Stuff")]
    public bool ended = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elpepeCam = elpepeArray[elpepePos];
        etesechCam = etesechArray[etesechPos];
        if (ended == true)
        {
            StartCoroutine(WaitSeconds(4));
            ended = false;
        }
    }

    private IEnumerator WaitSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        elpepeRandom = Random.Range(1, 20);
        etesechRandom = Random.Range(1, 20);

        if(elpepeAI > elpepeRandom)
        {
            if (elpepePos != elpepeArray.Length - 1)
            {
                elpepePos++;
                Debug.Log("avanza P");
            }else if (Random.Range(0,2) == 1)
            {
                elpepePos--;
                Debug.Log("retrocede P");
            }
        }

        if(etesechAI > etesechRandom)
        {
            if (etesechPos != etesechArray.Length - 1)
            {
                etesechPos++;
                Debug.Log("avanza S");
            }else if (Random.Range(0,2) == 1)
            {
                etesechPos--;
                Debug.Log("retrocede S");
            }
        }

        Debug.Log ("bop" + Random.Range(0,2));
        ended = true;
    }
}

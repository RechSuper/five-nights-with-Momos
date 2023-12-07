using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    [SerializeField] private Camera Camera;
    [SerializeField] private Collider coll1;
    public bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit raycastHit);
        if (raycastHit.collider == coll1 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (clicked == false)
            {
                clicked = true;
            }else
            {
                clicked = false;
            }
        }
    }
}

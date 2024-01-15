using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksManager : MonoBehaviour
{
    [SerializeField] private Camera MainCamera; //creamos una camara
    public RaycastHit raycastHit1; //raycasthit para los botones
    public RaycastHit raycastHit2; //raycasthit para el movimiento de la camara
    [SerializeField] private Collider coll1; // puerta izq
    [SerializeField] private Collider coll2; // puerta der
    [SerializeField] private Collider coll3; // luz izq
    [SerializeField] private Collider coll4; // luz der
    [SerializeField] private Collider collizq; // plano izq
    [SerializeField] private Collider collder; //plano der
    //los planos son unos planos (XD) que se ubican a la izquierda y derecha de la pantalla (o la camara)
    public LayerMask layerMask1; //layermask de los botones
    public LayerMask layerMask2; //layermask de los planos

    public bool clicked1 = false; //puerta izq
    public bool clicked2 = false; //puerta der
    public bool clicked3 = false; //luz izq
    public bool clicked4 = false; //luz der

    public Collider ositofredifasberNose; //la nariz del osito fredifasber
    [SerializeField] private AudioClip sonidofredifasber;

    public Material luz1;
    public Material luz2;
    public Material puerta1;
    public Material puerta2;

    public GameObject luzIzq;
    public GameObject luzDer;
    public GameObject puertaIzq;
    public GameObject puertaDer;

    bool ray1;
    bool ray2;

    // Awake pes
    void Awake()
    {
        MainCamera = Camera.main; //asigna MainCamera a la camara principal
    }

    // Update is called once per frame
    void Update()
    {
        ray1 = Physics.Raycast(MainCamera.ScreenPointToRay(Input.mousePosition), out raycastHit1, float.MaxValue, layerMask1); //rayo de los botones
        ray2 = Physics.Raycast(MainCamera.ScreenPointToRay(Input.mousePosition), out raycastHit2, float.MaxValue, layerMask2); //rayo de los planos
        //lo que hacen es lanzar un rayo en la posicion del mouse y la direccion de la camara, la info la sacan a raycastHit y usan un layermask (float.MaxValue es un infinito)

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
            if (raycastHit1.collider == coll1) //al presionar el boton del mouse comprobara si el ray1 impacto con un boton, sino pasa al siguiente y asi con todos
            {
                if (clicked1 == false)
                {
                    clicked1 = true;
                }else
                {
                    clicked1 = false;
                }
            }else if (raycastHit1.collider == coll2)
            {
                if (clicked2 == false)
                {
                    clicked2 = true;
                }else
                {
                    clicked2 = false;
                }
            }else if (raycastHit1.collider == coll3)
            {
                if (clicked3 == false)
                {
                    clicked3 = true;
                }else
                {
                    clicked3 = false;
                }
            }else if (raycastHit1.collider == coll4)
            {
                if (clicked4 == false)
                {
                    clicked4 = true;
                }else
                {
                    clicked4 = false;
                }
            }else if (raycastHit1.collider == ositofredifasberNose)
            {
                AudioManager.Instance.PlaySoundCutted(sonidofredifasber);
            }
        }

        if (Input.GetKey(KeyCode.Mouse0) && !ray1) //aca si mantienes el boton del mouse y el rayo no le dio a ningun boton la camara podra girar
        {
            if (raycastHit2.collider == collizq && MainCamera.transform.rotation.y >= -0.25) //si la camara no se paso del limite (-0.25 en este caso) al rotar y el rayo de los planos impacto
            //con un plano (en este caso el plano de la izq) rotara la camara, si no fue el plano izquierdo comprueba con el derecho y el limite del derecho 
            {
                MainCamera.transform.Rotate(new Vector3(0, -1, 0));
            }else  if (raycastHit2.collider == collder && MainCamera.transform.rotation.y <= 0.25)
            {
                MainCamera.transform.Rotate(new Vector3(0, 1, 0));
            }
        }

        if (clicked1 == true)
        {
            puertaIzq.GetComponent<Renderer>().material = puerta1;
        }else
        {
            puertaIzq.GetComponent<Renderer>().material = puerta2;
        }

        if (clicked2 == true)
        {
            puertaDer.GetComponent<Renderer>().material = puerta1;
        }else
        {
            puertaDer.GetComponent<Renderer>().material = puerta2;
        }

        if (clicked3 == true)
        {
            luzIzq.GetComponent<Renderer>().material = luz1;
        }else
        {
            luzIzq.GetComponent<Renderer>().material = luz2;
        }

        if (clicked4 == true)
        {
            luzDer.GetComponent<Renderer>().material = luz1;
        }else
        {
            luzDer.GetComponent<Renderer>().material = luz2;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{// he creado un menu manager para que controle todo lo del menu principal: botones, animcaiones, efectos y etc
    public void NuevoJuego (){// este metodo es para el boton NuevoJuego
        SceneManager.LoadScene(1);//carga la escena de Noche 1 pues unity la toma como Scene 1.
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI Noche;
    int NumeroDeNoche;
    // he creado un menu manager para que controle todo lo del menu principal: botones, animcaiones, efectos y etc
    public void NuevoJuego (){// este metodo es para el boton NuevoJuego
        SceneManager.LoadScene(1);//carga la escena de Noche 1 pues unity la toma como Scene 1.
    }
    public void Continuar(){//metodo para el boton de continuar
        NumeroDeNoche++; // sumamos un no cada que es tocado el boton la noche
        Noche.text = "night " + NumeroDeNoche; // luego esta es aplicada al texto
    }
}

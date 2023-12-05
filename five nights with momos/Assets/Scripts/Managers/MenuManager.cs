using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI NightText;
    [SerializeField] private GameManager gameManager; // he creado un menu manager para que controle todo lo del menu principal: botones, animcaiones, efectos y etc

    private void Awake()
    {
        NightText.text = "night " + gameManager.DatosJugador.NumeroDeNoche; // se cambiara el texto del objeto para que diga el numero de la noche
    }

    public void NuevoJuego () // este metodo es para el boton NuevoJuego
    {
        //carga la escena de Noche 1 pues unity la toma como Scene 1.
        SceneManager.LoadScene(1);
    }

    public void Continuar() //metodo para cuando clickeamos el boton de continuar
    {
        gameManager.DatosJugador.NumeroDeNoche++; // sumamos uno los datos del jugador del numero de la noche
        NightText.text = "night " + gameManager.DatosJugador.NumeroDeNoche; // luego esta es aplicada al texto
    }
}

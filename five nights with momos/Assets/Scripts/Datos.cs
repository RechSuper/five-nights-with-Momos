using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Datos{
    public int NumeroDeNoche;
    public int Estrellas;
    public bool CustomNight;

    public Datos(){ // como el objeto habeces no puede tener ningun valor le creamos un valor por defecto 
        NumeroDeNoche = 0;
        Estrellas = 0;
        CustomNight = false;
    }
}

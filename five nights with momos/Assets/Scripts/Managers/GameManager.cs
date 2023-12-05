using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{    
    public Datos DatosJugador;
    public TextMeshProUGUI NightText;
    void Awake()
    {
        var NoDestruir = FindObjectsOfType<GameManager>(); // no destruir = conjunto de objetos hijos del gamemanager
        if (NoDestruir.Length < 1){ // si el objeto hijo es el numero 0 o menor lo destruye //no es el objeto hijo, sino el mismo gameobject que al haber 2 se autodestruye para no causar interferencia
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);// mientras que los que no son menores a 1 osea el mismo gameobjetc seguiran con vida :) //aca si no hay otro game manager pasa a la siguiente sala
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            GuardarDatos();
        }
        if(Input.GetKeyDown(KeyCode.C)){
            AplicarDatos();
        }
    }
    void GuardarDatos(){
        string DatosJson = JsonUtility.ToJson(DatosJugador);//JsonUtility.ToJson crea una version de texto aun no real que este guardada en el disco sobre los DatosJugador
        string ruta = Path.Combine(Application.persistentDataPath, "Datos"); // creamos una ruta para poner la info del json dentro del disco y junto a su nombre que queremos que tenga
        File.WriteAllText(ruta, DatosJson); //con File.WriteAllText creamos el archivo json dentro del disco con una ruta y la info que queremos que tenga dentro
        
        Datos info = JsonUtility.FromJson<Datos>(DatosJson);// solo por moneria convertimos los DatosJson a variable normal
        Debug.Log(DatosJson);
        Debug.Log("Guardando " + info + " en " + ruta);
    }
    void AplicarDatos(){
        string ruta = Path.Combine(Application.persistentDataPath, "Datos");
        if(File.Exists(ruta)){ //ponemos la direcion del archivo json y le preguntamos si existe

            string contenidoString = File.ReadAllText(ruta); //si exsiste leera el archivo json para poner su contenido en una variable de tipo string con File.ReadAllText
            Datos datosNuevos = JsonUtility.FromJson<Datos>(contenidoString);//crea una nueva instancia del objeto de tido Datos con la informacion de contenidoString

            // como lo que se creo es una instancia del objeto Datos, entonces para que no haya problemas pues el que usamos es la instancia de Datos jugador no datosNuevos entonces hacemos
            DatosJugador.NumeroDeNoche = datosNuevos.NumeroDeNoche;
            DatosJugador.Estrellas = datosNuevos.Estrellas;
            DatosJugador.CustomNight = datosNuevos.CustomNight;

            NightText.text = "night " + DatosJugador.NumeroDeNoche;
            Debug.Log("Cargando json" + contenidoString);
            Debug.Log("Se cargo Estrellas " + DatosJugador.Estrellas + ", Numero de noche "+DatosJugador.NumeroDeNoche+", Custom night "+ DatosJugador.CustomNight);
        }
        else{
            Debug.Log("El archivo no existe");
        }
    }
}


using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
 // francia si lees esto quiero decirte que este codigo es para que cuando se pase a otra escena los objetos hijos del GameManager no se destruyan y se bayan juntos a la otra escena
    private void Awake() {
        var NoDestruir = FindObjectsOfType<GameManager>(); // no destruir = conjunto de objetos hijos del gamemanager
        if (NoDestruir.Length < 1){ // si el objeto hijo es el numero 0 o menor lo destruye
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);// mientras que los que no son menores a 1 osea el mismo gameobjetc seguiran con vida :)
    }
}

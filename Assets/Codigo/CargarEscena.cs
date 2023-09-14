using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    // Nombre de la escena que quieres cargar. Asegúrate de que el nombre coincide con el de tu escena en el proyecto de Unity.
    public string nombreDeLaEscenaARecargar;

    public void CargarOtraEscena()
    {
        // Utiliza SceneManager para cargar la escena deseada.
        SceneManager.LoadScene(nombreDeLaEscenaARecargar);
    }
}
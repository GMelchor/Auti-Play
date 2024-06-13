using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    public GameObject Pantalla_Inicio,PantallaInicio, Pantalla_Opciones, Pantalla_Clasi, PantallaActividades;
    
    public void CambioPanelActividades (GameObject PantallaActividades ){

        PantallaActividades.SetActive(true);
        PantallaInicio.SetActive(false);

    }

    public void CambioRegresar (GameObject PantallaInicio){
        PantallaInicio.SetActive(true);
        Pantalla_Clasi.SetActive(false);
        Pantalla_Opciones.SetActive(false);
        PantallaActividades.SetActive(false);
    }

    public void Salir (){
        
        Application.Quit();
    }

    public void Clasificacion(GameObject Pantalla_Clasi){
        Pantalla_Clasi.SetActive(true);
        Pantalla_Inicio.SetActive(false);
    }

    public void Opciones(GameObject Pantalla_Opciones){
        Pantalla_Opciones.SetActive(true);
        Pantalla_Inicio.SetActive(false);
    }

}

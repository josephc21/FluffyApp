using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarHistorial : MonoBehaviour
{
    public Text txtHisto1;
    public Text txtHisto2;
    public Text txtHisto3;
    public Text txtNomb;

    // Start is called before the first frame update
    void Start()
    {
        //SaveID.saveID;
        txtHisto1.text = "Nombre: " + PlayerPrefs.GetString("Nombre" + 1) 
        + ". Nivel: " + (PlayerPrefs.GetInt("NivelActual" + 1)).ToString() 
        +". Puntaje: " + (PlayerPrefs.GetInt("Puntaje" + 1)).ToString() + ". Fecha: " + PlayerPrefs.GetString("Fecha" + 1) 
        + ". Hora: " + PlayerPrefs.GetString("Hora" + 1) + ".";

        txtHisto2.text = "Nombre: " + PlayerPrefs.GetString("Nombre" + 2)
        + ". Nivel: " + (PlayerPrefs.GetInt("NivelActual" + 2)).ToString()
        + ". Puntaje: " + (PlayerPrefs.GetInt("Puntaje" + 2)).ToString() + ". Fecha: " + PlayerPrefs.GetString("Fecha" + 2)
        + ". Hora: " + PlayerPrefs.GetString("Hora" + 2) + ".";

        txtHisto3.text = "Nombre: " + PlayerPrefs.GetString("Nombre" + 3)
        + ". Nivel: " + (PlayerPrefs.GetInt("NivelActual" + 3)).ToString()
        + ". Puntaje: " + (PlayerPrefs.GetInt("Puntaje" + 3)).ToString() + ". Fecha: " + PlayerPrefs.GetString("Fecha" + 3)
        + ". Hora: " + PlayerPrefs.GetString("Hora" + 3) + ".";


        if (PlayerPrefs.GetInt("Slot" + SaveID.saveID) == 1)
        {
            txtNomb.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
        }

        if (SaveID.saveID != 1 && SaveID.saveID != 2 && SaveID.saveID != 3)
        {
            txtNomb.text = "Jugando con ...";
        }

        //txtNivel.text = (PlayerPrefs.GetInt("Puntaje" + 1)).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

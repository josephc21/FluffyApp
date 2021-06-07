using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaDatos : MonoBehaviour
{
    public InputField inpNombre;
    public InputField inpNombre2;
    public InputField inpNombre3;
    public GameObject inp;
    public GameObject inp2;
    public GameObject inp3;
    public Text txtNombreNiño;
    public GameObject[] newGameButtons = new GameObject[3];
    public GameObject[] loadGameButtons = new GameObject[3];
    public GameObject[] clearGameButtons = new GameObject[3];
    public int[] saveIds = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        Botones();
    }

    // Update is called once per frame
    void Update() //desactiva y activa los botones de guardado y de cargar respectivamente
    {
        
    }

    public void Botones()
    {
        if (PlayerPrefs.GetInt("Slot" + saveIds[0]) == 1)
        {
            txtNombreNiño.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
            loadGameButtons[0].SetActive(true);
            newGameButtons[0].SetActive(false);
            clearGameButtons[0].SetActive(true);
            inp.SetActive(false);
        }
        else
        {
            loadGameButtons[0].SetActive(false);
            newGameButtons[0].SetActive(true);
            clearGameButtons[0].SetActive(false);
            inp.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Slot" + saveIds[1]) == 1)
        {
            txtNombreNiño.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
            loadGameButtons[1].SetActive(true);
            newGameButtons[1].SetActive(false);
            clearGameButtons[1].SetActive(true);
            inp2.SetActive(false);
        }
        else
        {
            loadGameButtons[1].SetActive(false);
            newGameButtons[1].SetActive(true);
            clearGameButtons[1].SetActive(false);
            inp2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Slot" + saveIds[2]) == 1)
        {
            txtNombreNiño.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
            loadGameButtons[2].SetActive(true);
            newGameButtons[2].SetActive(false);
            clearGameButtons[2].SetActive(true);
            inp3.SetActive(false);
        }
        else
        {
            loadGameButtons[2].SetActive(false);
            newGameButtons[2].SetActive(true);
            clearGameButtons[2].SetActive(false);
            inp3.SetActive(true);
        }

        if (SaveID.saveID != 1 && SaveID.saveID != 2 && SaveID.saveID != 3)
        {
            txtNombreNiño.text = "Jugando con ...";
        }
    }

    public void LoadName() //metodo para poder cargar el nombre del niño actual
    {
        if (PlayerPrefs.GetInt("Slot" + SaveID.saveID) == 1)
        {
            txtNombreNiño.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
        }
        else
            return;
    }

    public void GuardarDatosIniciales()
    {

        // se obtiene fecha y hora actual del sistema
        string Fecha = System.DateTime.Now.ToString("dd/MM/yyyy");
        string Hora = System.DateTime.Now.ToString("HH:mm:ss");

        PlayerPrefs.SetInt("Slot" + SaveID.saveID, 1);
        if(SaveID.saveID == 1)
        {
            PlayerPrefs.SetString("Nombre" + SaveID.saveID, inpNombre.text);
        }
        if (SaveID.saveID == 2)
        {
            PlayerPrefs.SetString("Nombre" + SaveID.saveID, inpNombre2.text);
        }
        if (SaveID.saveID == 3)
        {
            PlayerPrefs.SetString("Nombre" + SaveID.saveID, inpNombre3.text);
        }
        //establece los datos de cada perfil, llave + el id seguido del valor
        PlayerPrefs.SetString("Fecha" + SaveID.saveID, Fecha);
        PlayerPrefs.SetString("Hora" + SaveID.saveID, Hora);
        PlayerPrefs.SetInt(("Puntaje" + SaveID.saveID), 0);
        PlayerPrefs.SetInt(("NivelActual" + SaveID.saveID), 1);
        PlayerPrefs.SetInt(("NivelSuperado" + SaveID.saveID), 0);
        SetSaveID(0);
    }

    public void SetSaveID(int saveID) //variable SaveID.saveID
    {
        SaveID.saveID = saveID;
    }

    public void ClearSave(int saveID) //borrar perfil
    {
        PlayerPrefs.DeleteKey("Nombre" + saveID);
        PlayerPrefs.DeleteKey("Fecha" + saveID);
        PlayerPrefs.DeleteKey("Hora" + saveID);
        PlayerPrefs.DeleteKey("Puntaje" + saveID);
        PlayerPrefs.DeleteKey("NivelActual" + saveID);
        PlayerPrefs.DeleteKey("NivelSuperado" + saveID);
        PlayerPrefs.DeleteKey("Slot" + saveID);
        SetSaveID(0);
        Botones();
    }
}

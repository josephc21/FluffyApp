using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles : MonoBehaviour
{
    public Text txtNomb;
    public Button Button1;
    public Button Button2;
    public Button Button3;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Slot" + SaveID.saveID) == 1)
        {
            txtNomb.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
        }

        ComprobarNivel();

        if (SaveID.saveID != 1 && SaveID.saveID != 2 && SaveID.saveID != 3)
        {
            txtNomb.text = "Jugando con ...";
            Button1.interactable = false;
            Button2.interactable = false;
            Button3.interactable = false;
        }

    }

    public void ComprobarNivel()
    {
        if (PlayerPrefs.GetInt("Slot" + SaveID.saveID) == 1)
        {
            if (PlayerPrefs.GetInt("NivelSuperado" + SaveID.saveID) < 2)
            {
                Button2.interactable = true;
                Button3.interactable = false;
             }

            if (PlayerPrefs.GetInt("NivelSuperado" + SaveID.saveID) < 1)
            {
                //Se cambio a true button2 solo para observar el nivel2. 
                Button2.interactable = false;
                Button3.interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

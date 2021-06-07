using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu2 : MonoBehaviour
{
    public Text txtNomb;
    public Button btnJugar;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Slot" + SaveID.saveID) == 1)
        {
            txtNomb.text = "Jugando con " + PlayerPrefs.GetString("Nombre" + SaveID.saveID);
        }

        if (SaveID.saveID != 1 && SaveID.saveID != 2 && SaveID.saveID != 3)
        {
            txtNomb.text = "Jugando con ...";
            btnJugar.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Text tiempoText;
    public float tiempo = 0.0f;
    public int tiempoCambio = 90;

    public void Update()
    {
        tiempo -= Time.deltaTime;
        tiempoText.text = " " + tiempo.ToString("f0");

        //if (tiempo >= tiempoCambio)
        //{
        //    SceneManager.LoadScene("SeleccionNivel");
        //}

    }

  








}

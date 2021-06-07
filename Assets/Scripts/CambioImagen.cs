using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioImagen : MonoBehaviour
{
    public Image imagenUIOso;
    public Image imagenUIObjeto;
    public Text mensaje1;
    public string valorMensaje1;
    public Text mensaje2;
    public string valorMensaje2;
    public Text tiempoText;


  //  public string mensajeError = "Vuelve a intentarlo";
    public float tiempo = 0.0f;
   // public int tiempoCambio = 90;


    public void Start()
    {
        this.imagenUIOso = GameObject.Find("ImageCambianteOsitos").GetComponent<Image>();
        this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso");

        this.imagenUIObjeto = GameObject.Find("ImagenCambianteObjetos").GetComponent<Image>();
        //   this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Cubo");
       
        
    }

    public void Update()
    {
      
        tiempo -= Time.deltaTime;
        tiempoText.text = " " + tiempo.ToString("f0");

        if (tiempo<= 120)
        {
            mensaje1.text = valorMensaje1;
        }

        if (tiempo<= 105)
        {
            //   SceneManager.LoadScene("NivelUnoAr");

            mensaje1.text = " ";
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso1");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Cubo");
            
        }
       
        if (tiempo<= 90)
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso2");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Chupon");
        }

        if (tiempo <= 75)
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso3");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Campana");
        }

        if (tiempo <= 60)
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso4");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/biberon");
        }

        if (tiempo<= 45)
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso2");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Chupon");
        }
        if (tiempo <= 30 )
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso3");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Campana");
        }
        if (tiempo <= 15 )
        {
            this.imagenUIOso.sprite = Resources.Load<Sprite>("Sprite/Oso1");
            this.imagenUIObjeto.sprite = Resources.Load<Sprite>("Sprite/Cubo");
        }
        
        if(tiempo<= 2)
        {
            mensaje2.text = valorMensaje2;
        }

        if (tiempo<= 0)
        {
            SceneManager.LoadScene("NivelUnoAr");
        }




        //if (Input.GetKeyDown("q"))
        //{
        //    this.imagenUI.sprite = Resources.Load<Sprite>("Sprite/Oso1");

        //}
        //if (Input.GetKeyDown("s"))
        //{
        //        this.imagenUI.sprite = Resources.Load<Sprite>("Sprite/Oso2");
        //}
    }
}

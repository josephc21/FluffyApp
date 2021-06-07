using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosObjNivel2 : MonoBehaviour
{
    public AudioClip[] tone;
    public AudioSource myAudioSource;
    string btnName;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                btnName = raycastHit.transform.name;
                switch (btnName)
                {
                    case "CuboSonidoFluffyMorado":
                        myAudioSource.clip = tone[0];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoGlobo":
                        myAudioSource.clip = tone[1];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoPato":
                        myAudioSource.clip = tone[2];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoSonaja":
                        myAudioSource.clip = tone[3];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidomovilMusical":
                        myAudioSource.clip = tone[4];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoPelota":
                        myAudioSource.clip = tone[5];
                        myAudioSource.Play();
                        break;

                    default:
                        break;
                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosObjNivel1 : MonoBehaviour
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
                    case "CuboSonidoBiberon":
                        myAudioSource.clip = tone[0];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoCampana":
                        myAudioSource.clip = tone[1];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoChupon":
                        myAudioSource.clip = tone[2];
                        myAudioSource.Play();
                        break;

                    case "CuboSonidoCubo":
                        myAudioSource.clip = tone[3];
                        myAudioSource.Play();
                        break;

                    default:
                        break;
                }
            }

        }

    }
}

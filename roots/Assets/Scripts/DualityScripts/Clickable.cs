using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
  
    public GameObject item1;
    public GameObject item2;

    public int OneStay2Enter = 1; //1 = button 2 = pressure plate

    public AudioSource buttonSound;

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetMouseButtonDown(0)) //left click
            {
                if (OneStay2Enter == 1)
                {
                    if (item1?.activeSelf == true)
                    {
                        item1.SetActive(false);
                        item2.SetActive(true);
                        buttonSound.Play();
                    }

                    else if (item1?.activeSelf == false)
                    {
                        item1.SetActive(true);
                        item2.SetActive(false);
                        buttonSound.Play();
                    }

                }



            }
            //  if (OneStay2Enter == 2 && col.gameObject.tag == "ball" && col.gameObject.tag != "Player")
            // {
            //     item1.SetActive(false);
            //     item2.SetActive(true);
            //   }

            // Update other objects position and rotation

            // thing.transform.rotation = Destination.transform.rotation;
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetMouseButtonDown(0)) //left click
            {
                if (OneStay2Enter == 1)
                {
                    if (item1?.activeSelf == true)
                    {
                        item1.SetActive(false);
                        item2.SetActive(true);
                       
                        buttonSound.Play();
                    }

                    else if (item1?.activeSelf == false)
                    {
                        item1.SetActive(true);
                        item2.SetActive(false);
                       
                        buttonSound.Play();
                    }

                }



            }
            //  if (OneStay2Enter == 2 && col.gameObject.tag == "ball" && col.gameObject.tag != "Player")
            // {
            //     item1.SetActive(false);
            //     item2.SetActive(true);
            //   }

            // Update other objects position and rotation

            // thing.transform.rotation = Destination.transform.rotation;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class him : MonoBehaviour
{

    public AudioSource song;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            song.Play();

            Destroy(this);
        }

    }

}

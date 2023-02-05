using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Destination;

    public AudioSource warpSound;






    public void OnTriggerEnter(Collider other)
    {


        // If the tag of the colliding object is allowed to teleport
        if (other.gameObject.tag == "Player")
        {

            other.transform.position = Destination.transform.position;
            other.transform.rotation = Destination.transform.rotation;
            warpSound.Play();


            // Update other objects position and rotation

        }
    }


    public void OnTriggerStay(Collider other)
    {


        // If the tag of the colliding object is allowed to teleport
        if (other.gameObject.tag == "Player")
        {

            other.transform.position = Destination.transform.position;
            other.transform.rotation = Destination.transform.rotation;
            warpSound.Play();


        }
    }
}

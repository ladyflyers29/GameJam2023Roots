using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTunnel : MonoBehaviour
{
    public GameObject windtunnel;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Root" || other.gameObject.tag == "Root2")
        {
            windtunnel.SetActive(false);
        }

        else
        {
            windtunnel.SetActive(true);
        }
    }
}

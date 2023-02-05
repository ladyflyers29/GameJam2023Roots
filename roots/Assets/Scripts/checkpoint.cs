using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject warpzone;
    public GameObject checkpoint2;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            warpzone.SetActive(true);
            Destroy(checkpoint2.gameObject);
        }
    }
}

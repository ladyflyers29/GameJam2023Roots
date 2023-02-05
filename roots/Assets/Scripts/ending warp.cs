using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingwarp : MonoBehaviour
{
    // private GameObject FindandDestroy;
    // public string hiddenstar;

    //public GameObject greenbox;

   

    //public GameObject works;

    void FixedUpdate()
    {
        //GameObject.FindWithTag("Booloo");
        //FindandDestroy = GameObject.FindWithTag("Booloo");






    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(2);
        }





    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(2);
        }





    }

}

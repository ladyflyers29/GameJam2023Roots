using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneWarp : MonoBehaviour
{
 
   







    // private GameObject FindandDestroy;
    // public string hiddenstar;

    //public GameObject greenbox;

    public int completionnumber = 1;

    //public GameObject works;

    void FixedUpdate()
    {
        //GameObject.FindWithTag("Booloo");
        //FindandDestroy = GameObject.FindWithTag("Booloo");



       


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(y + 1);
        }
            




    }

  

}

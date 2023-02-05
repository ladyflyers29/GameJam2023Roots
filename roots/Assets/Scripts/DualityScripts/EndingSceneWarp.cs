using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneWarp : MonoBehaviour
{









    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(1);
        }





    }



}

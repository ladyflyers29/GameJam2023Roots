using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public Material skybox6;
    public GameObject potatoe;
    public float lifeTime = 10f;




    private void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            RenderSettings.skybox = skybox6;
            potatoe.SetActive(true);
        }
    }


    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("MainCamera"))
        {
          

                RenderSettings.skybox = skybox6;
            potatoe.SetActive(true);
               


            




        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("MainCamera"))
        {


            RenderSettings.skybox = skybox6;
            potatoe.SetActive(true);








        }
    }
}

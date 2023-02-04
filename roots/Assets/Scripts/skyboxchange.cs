using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxchange : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
    public Material skybox3;
    public Material skybox4;
    public Material skybox5;

    public int changesky = 0;



    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (changesky == 1)
            {
                RenderSettings.skybox = skybox1;
            }

            else if (changesky == 2)
            {
                RenderSettings.skybox = skybox2;
            }
            else if (changesky == 3)
            {
                RenderSettings.skybox = skybox3;
            }
            else if (changesky == 4)
            {
                RenderSettings.skybox = skybox4;
            }
            else if (changesky == 5)
            {
                RenderSettings.skybox = skybox5;
            }
        }

        
    }
}

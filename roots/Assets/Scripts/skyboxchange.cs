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

    public GameObject swamp1;
    public GameObject swamp2;
    public GameObject hill1;
    public GameObject hill2;
    public GameObject space;
    public GameObject western;

    public GameObject Clouds;

    public int changesky = 0;
    public int variant = 1;



    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (changesky == 1)
            {
               
                    RenderSettings.skybox = skybox1;
                    hill1.SetActive(true);

                hill2.SetActive(false);
                swamp1.SetActive(false);
                swamp2.SetActive(false);
                space.SetActive(false);
                western.SetActive(false);


            }

            else if (changesky == 2)
            {
                if (variant == 1)
                {
                    RenderSettings.skybox = skybox2;
                    swamp1.SetActive(true);

                    hill2.SetActive(false);
                    hill1.SetActive(false);
                    swamp2.SetActive(false);
                    space.SetActive(false);
                    western.SetActive(false);
                    Clouds.SetActive(true);
                }

                else if (variant == 2)
                {
                    RenderSettings.skybox = skybox2;
                    swamp2.SetActive(true);

                    hill2.SetActive(false);
                    swamp1.SetActive(false);
                    hill1.SetActive(false);
                    space.SetActive(false);
                    western.SetActive(false);
                    Clouds.SetActive(true);
                }

             
            }
            else if (changesky == 3)
            {
                RenderSettings.skybox = skybox3;
                hill2.SetActive(true);

                hill1.SetActive(false);
                swamp1.SetActive(false);
                swamp2.SetActive(false);
                space.SetActive(false);
                western.SetActive(false);
                Clouds.SetActive(true);


            }
            else if (changesky == 4)
            {
                RenderSettings.skybox = skybox4;
                space.SetActive(true);

                hill2.SetActive(false);
                swamp1.SetActive(false);
                swamp2.SetActive(false);
                hill1.SetActive(false);
                western.SetActive(false);
                Clouds.SetActive(false);
            }
            else if (changesky == 5)
            {
                RenderSettings.skybox = skybox5;

                hill2.SetActive(false);
                hill1.SetActive(false);
                swamp1.SetActive(false);
                swamp2.SetActive(false);
                space.SetActive(false);
                western.SetActive(true);
                Clouds.SetActive(true);

            }
        }

        
    }
}

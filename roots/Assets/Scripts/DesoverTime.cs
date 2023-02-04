using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesoverTime : MonoBehaviour
{
    public float lifeTime = 10f;


    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
        }

        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

    }
}

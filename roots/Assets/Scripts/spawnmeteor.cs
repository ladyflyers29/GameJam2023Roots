using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmeteor : MonoBehaviour
{
    public GameObject m_Projectile;    // this is a reference to your projectile prefab
    public Transform m_SpawnTransform; // this is a reference to the transform where the prefab will spawn

    public float timeLeft;

    void Update()
    {
        timeLeft -= Time.deltaTime;

       

    
        if (timeLeft < 0)
        {
            Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
            timeLeft = 10;
        }
    }

    
}


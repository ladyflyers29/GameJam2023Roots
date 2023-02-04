using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveback : MonoBehaviour
{
    static Collider[] cachedCols = new Collider[16];
    /// <summary>
    /// change monsters direction (back and forth) if it runs into a object tagged "blockTag"
    /// </summary>
    public float movespeed = 3;
    public LayerMask collideWithLayers = int.MaxValue;
    public string collideWithTag = "blockTag";
    public float minTimeBeforeNextBounce = 0.1f;

    float elapsedTimeSinceLastBounce;

    public void FixedUpdate() 
    {
        elapsedTimeSinceLastBounce += Time.fixedDeltaTime;
        int numOfCollidersHit = Physics.OverlapBoxNonAlloc( transform.position, transform.localScale * 0.5f, cachedCols, transform.rotation, collideWithLayers );
        for (int i = 0; i < numOfCollidersHit; i++) {
            Collider colliderToCheck = cachedCols[i];
            if (elapsedTimeSinceLastBounce > minTimeBeforeNextBounce && colliderToCheck.gameObject.tag == collideWithTag) {
                elapsedTimeSinceLastBounce = 0;
                movespeed = -movespeed;
                Debug.DrawLine( transform.position, colliderToCheck.transform.position, Color.magenta, 0.5f );
            }
        }
        transform.position += transform.forward * movespeed * Time.fixedDeltaTime;
    }

}

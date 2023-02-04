using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movegrass2 : MonoBehaviour
{
    void Update()
    {
        Shader.SetGlobalVector("_PositionMoving", transform.position);
    }
}

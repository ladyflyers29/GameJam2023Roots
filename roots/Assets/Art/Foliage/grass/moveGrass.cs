using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGrass : MonoBehaviour
{
    void Update()
    {
        Shader.SetGlobalVector("_PositionMoving", transform.position);
    }
}

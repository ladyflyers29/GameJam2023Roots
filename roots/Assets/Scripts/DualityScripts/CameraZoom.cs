using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{    
    public AnimationCurve fovOverTime;
    float elapsed;
    float initialfov;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        initialfov = cam.fieldOfView;
     
    }

    void Update() {
        elapsed += Time.deltaTime;
        cam.fieldOfView = initialfov + fovOverTime.Evaluate( elapsed );
    }

    void PlayAnim()
    {
        elapsed = 0;
    }
}

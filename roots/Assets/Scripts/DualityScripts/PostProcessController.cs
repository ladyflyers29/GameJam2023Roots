using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessController : MonoBehaviour {
    
    public PostProcessProfile lightWorldProfile;
    public PostProcessProfile darkWorldProfile;
    public PostProcessVolume postProcessVolume;

    void Awake() {
        
        if (lightWorldProfile == null) throw new Exception("LightWorldProfile not assigned! You FOOL");
        if (darkWorldProfile == null)  throw new Exception("DarkWorldProfile not assigned! You DINGUS");
        if (postProcessVolume == null) throw new Exception("postprocess not assigned! You utter NINCOMPOOP");
        
    }

    void OnDestroy() {
     
    }

    

}

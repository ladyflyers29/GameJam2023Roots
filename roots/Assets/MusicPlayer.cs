using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioClip musicTrack;
    [SerializeField] float smoothChangeMusic;
    AudioSource source;
    float speedGoal = 1f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
     
    }

    void Update() {
        source.pitch = Mathf.Lerp( source.pitch, speedGoal, Time.deltaTime * smoothChangeMusic);
    }

    
}

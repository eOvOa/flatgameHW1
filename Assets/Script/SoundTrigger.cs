using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private AudioSource leaking;
    // Start is called before the first frame update
    void Start()
    {
        leaking = this.GetComponent<AudioSource>();
        leaking.volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!leaking.isPlaying){
            leaking.Play();
        }
        
    }
}

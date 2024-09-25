using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float minimumX;
    public float maximumX;
    public Sprite dialogue;
    public Sprite blank;
    public AudioSource soundEffect;
    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x >= minimumX && character.transform.position.x <= maximumX){
            this.GetComponent<SpriteRenderer>().sprite = dialogue;
            if (!soundEffect.isPlaying){
                soundEffect.Play();
            }
        } else {
            this.GetComponent<SpriteRenderer>().sprite = blank;
            soundEffect.Stop();
        }
    }
}

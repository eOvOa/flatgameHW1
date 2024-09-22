using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    private Animator animator;
    private SpriteRenderer sprite;
    private AudioSource stepAudio;


    public AudioSource streamAudio;
    public AudioSource birdAudio;
    public AudioSource cowAudio;

    public SpriteRenderer dialogue;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        sprite = this.GetComponent<SpriteRenderer>();
        stepAudio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0, 0, 0);
        if (transform.position.x >= -14.83f)
        {
            if (Input.GetKey(KeyCode.D))
            {
                sprite.flipX = false;
                animator.SetBool("IsWalk", true);
                stepAudio.Play();
                vel += new Vector3(speed, 0, 0);
                transform.position += vel;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("IsWalk", true);
                sprite.flipX = true;
                stepAudio.Play();
                vel -= new Vector3(speed, 0, 0);
                transform.position += vel;
            }
            else
            {
                animator.SetBool("IsWalk", false);
                stepAudio.Stop();
            }
        }

        if (transform.position.x < -14.83){
            Vector3 start = new Vector3(-14.82f, -1.17f, 0);
            transform.position = start;
        }
        
    }
}

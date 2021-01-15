
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorund_check : MonoBehaviour
{
    walk walk;
    Animator anim;

    [SerializeField]
    AudioClip[] sounds;

    void Start(){
        walk = transform.root.gameObject.GetComponent<walk> ();
        anim = transform.root.gameObject.GetComponent<Animator> ();
        Debug.Log("ground_check.cs-anim Tanımlandı");
        Debug.Log("ground_check.cs-walk Tanımlandı");
    }

    void OnTriggerEnter2D()
    {
        walk.isGround = true;
        anim.SetBool("isGround", true);
        transform.root.GetComponent<AudioSource>().PlayOneShot(sounds[Random.Range(0,2)]);
        Debug.Log("ground_check.cs-Karakter Yere Değdi");
    }
    void OnTriggerStay2D ()
    {
        walk.isGround = true;
        anim.SetBool("isGround", true);
    }

    void OnTriggerExit2D ()
    {
        walk.isGround = false;
        anim.SetBool("isGround", false);
    }
}


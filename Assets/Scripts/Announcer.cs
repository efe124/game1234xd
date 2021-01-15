using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcer : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] phase1;

    [SerializeField]
    private AudioClip[] phasef;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(phase1[Random.Range(0, 5)]);
        Invoke("phase2", 2.5f);
    }

    void phase2()
    {
        GetComponent<AudioSource>().PlayOneShot(phasef[Random.Range(0, 5)]);

    }
    
}

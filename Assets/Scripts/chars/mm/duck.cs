using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : MonoBehaviour
{
    Animator anim;
    BoxCollider2D idleBox;
    BoxCollider2D duckBox;
    walk walkScript;
    void Start()
    {
        anim = transform.root.gameObject.GetComponent<Animator>();
        idleBox = transform.root.gameObject.GetComponent<BoxCollider2D>();
        duckBox = GetComponent<BoxCollider2D>();
        walkScript = transform.root.gameObject.GetComponent<walk>();
        Debug.Log("duck.cs-anim tanımlandı");
        Debug.Log("duck.cs-idleBox tanımlandı");
        Debug.Log("duck.cs-duckBox tanımlandı");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            idleBox.isTrigger = true;
            duckBox.isTrigger = false;
            anim.SetBool("Duck", true);
            walkScript.duck = true;
            Debug.Log("duck.cs-Karakter Eğildi");

        }

        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            idleBox.isTrigger = false;
            duckBox.isTrigger = true;
            walkScript.duck = false;
            anim.SetBool("Duck", false);

        }
    }
}

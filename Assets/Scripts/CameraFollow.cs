using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    [SerializeField]
    private float SmoothX;
    [SerializeField]
    private float SmoothY;

    [SerializeField]
    private float minX;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private float maxY;



    void Start()
    {
        player = GameObject.Find("Mugman").transform;


    }

    void LateUpdate()
    {
        float posX = Mathf.MoveTowards(transform.position.x, player.position.x, SmoothX);
        float posY = Mathf.MoveTowards(transform.position.y, player.position.y, SmoothY);

        transform.position = new Vector3(Mathf.Clamp(posX,minX,maxX), Mathf.Clamp(posY,minY,maxX), transform.position.z);

    }
}

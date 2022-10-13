using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    //intiialises the offset as it takes the intial position of the camera
    void Start()
    {
        offset = transform.position;
    }

    //modifies the camera position by adding offset to the position of the player
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

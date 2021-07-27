using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    //Edge boundary
    private float minXPos;
    private float maxXPos;

    private void Awake()
    {
        minXPos = player.position.x;
    }

    void Update()
    {   

        //Take spawn position and do not let camera pass.
        //Math clamp?
        /*
        if (player.position.x  < 2)
        {
            Debug.Log("Camera boundary triggered.");
            transform.position = new Vector3(2, player.position.y + offset.y, offset.z);
        }*/

        //Make the camera's position change in accordance with player position
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); 
    }
   
}

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
        //Get player initial x value as minimum "boundary" of level
        minXPos = player.position.x;
        //We want to keep the camera following the player
        //Don't want to use.
        DontDestroyOnLoad(this.gameObject);
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

        if (player.transform.position.x <= minXPos)
        {
            Debug.Log("Camera boundary triggered.");
            transform.position = new Vector3(minXPos + offset.x, player.position.y + offset.y, offset.z);
            return;
        }

        //Make the camera's position change in accordance with player position
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); 
    }
   
}

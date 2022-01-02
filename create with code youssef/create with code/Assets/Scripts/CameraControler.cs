using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    //refreance game object for position
    public GameObject player;

    //private var
    Vector3 cameraOffset = new Vector3(0, 5, -7);
    

    //late update to keep from visual artifacting
    void LateUpdate()
    {
        //sets and keeps the player camera relative to player vehical
        transform.position = player.transform.position + cameraOffset ;
    }
}

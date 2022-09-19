using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Variables for the player and for the the vector3 offset
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //Positions the camera to the side of player character so that it follows the player
        transform.position = plane.transform.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlaneX : MonoBehaviour
{
    // object to follow
    public GameObject plane;

    // camera location vector
    Vector3 cameraOffset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // camera follows plane
        transform.position = plane.transform.position + cameraOffset;
    }
}

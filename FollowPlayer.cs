using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // used to identify player object - add player component to camera so it can follow player
    public GameObject player;

    // camera offset variable - so we can access it easier
    Vector3 cameraOffset = new Vector3(0, 8, -12);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update() is called once per frame - use LateUpdate() to reduce camera jitter
    void LateUpdate()
    {
        // moves camera based on position of player
        transform.position = player.transform.position + cameraOffset;
    }
}

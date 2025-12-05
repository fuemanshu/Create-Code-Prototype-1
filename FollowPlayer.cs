using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // used to identify player object - add player component to camera so it can follow player
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moves camera based on position of player
        transform.position = player.transform.position;
    }
}

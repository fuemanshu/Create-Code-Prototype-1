using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Player movement speed
    public float playerSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle forward, at a reasonable realistic speed 
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);  // this version moves the player automatically
    }
}

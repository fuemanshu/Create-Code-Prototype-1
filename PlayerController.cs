using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Player movement speed
    public float playerSpeed = 15.0f;

    // player turn speed
    public float playerTurnSpeed = 5.0f;

    // player input variable for movement
    public float playerHorizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player movement input
        playerHorizontalInput = Input.GetAxis("Horizontal");

        // Move vehicle forward, at a reasonable realistic speed 
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);  // this version moves the player automatically

        // player turn movement
        transform.Translate(Vector3.right * Time.deltaTime * playerTurnSpeed * playerHorizontalInput);
    }
}

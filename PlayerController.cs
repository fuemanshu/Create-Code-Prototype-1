using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Player movement speed
    private float playerSpeed = 15.0f;

    // player turn speed
    private float playerTurnSpeed = 45.0f;

    // player input variable for movement
    private float playerHorizontalInput;

    // player forward and backward movement speed and input
    private float playerForwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player movement input
        playerHorizontalInput = Input.GetAxis("Horizontal");    // left and right
        playerForwardInput = Input.GetAxis("Vertical");         // forward and backward

        // Move vehicle forward, at a reasonable realistic speed 
        // transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);  // this version moves the player automatically
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * playerForwardInput);  // this version moves based on player input

        // player turn movement
        // transform.Translate(Vector3.right * Time.deltaTime * playerTurnSpeed * playerHorizontalInput);   // this movement slides player left and right
        // rotate vehicle during horizontal movement instead of sliding
        transform.Rotate(Vector3.up, playerTurnSpeed * playerHorizontalInput * Time.deltaTime);             // this movement rotates player/object
    }
}

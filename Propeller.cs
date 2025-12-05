using UnityEngine;

public class Propeller : MonoBehaviour
{
    // plane propeller rotation variable
    private float propellerRotationSpeed = 2500.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate propeller
        transform.Rotate(Vector3.back * propellerRotationSpeed * Time.deltaTime);
    }
}

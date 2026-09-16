using UnityEngine;

public class TrapController : MonoBehaviour
{

    public float rotationSpeed = 100f;
    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(0,
        rotationSpeed * Time.fixedDeltaTime, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}

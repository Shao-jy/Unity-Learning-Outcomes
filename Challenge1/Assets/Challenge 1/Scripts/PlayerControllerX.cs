using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20f;
    private float rotationSpeed = 60f;
    public float verticalInput;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        //transform.Translate(Vector3.forward * speed);
        Vector3 move = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.left, verticalInput * rotationSpeed);

        Quaternion rot = Quaternion.Euler(-verticalInput * rotationSpeed * Time.fixedDeltaTime, 0, 0);
        rb.MoveRotation(rb.rotation * rot);
        /*
        Vector3 direction = new Vector3(0, verticalInput, 0);

        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime));
        }
        */
    }
}

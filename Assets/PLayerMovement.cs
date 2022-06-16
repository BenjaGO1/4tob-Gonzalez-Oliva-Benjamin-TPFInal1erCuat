using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerMovement : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;
    public int counter = 2;

    int hasJump;
    Rigidbody rb;

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) && hasJump==maxJumps)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) && hasJump == maxJumps)
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.Space) && hasJump>0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
        if (counter <= 0)
        {
            SceneManager.LoadScene("Ganaste");
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "ground")
        {
            hasJump = maxJumps;
        }
        if (col.gameObject.name == "Enemy")
        {
            Debug.Log("Impactaron");
            SceneManager.LoadScene("Perdiste");
        }
    }
}

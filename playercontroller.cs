using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    private bool isGrounded;
    private bool jump;
    private Rigidbody rb;
    private int count;
    private Vector3 jumpDirection;

    public float speed;
    public Text countText;
    public Text winText;
    public float jumpForce;
    public int amountofcubes;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate()
    {
      float moveHorizontal = Input.GetAxis ("Horizontal");
      float moveVertical = Input.GetAxis ("Vertical");

      jump = Input.GetButton("Jump");


      Vector3 up = new Vector3 (0.0f, 1.0f, 0.0f);
      Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

      rb.AddForce (movement * speed);
      Jump();
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.CompareTag("pickup"))
      {
        other.gameObject.SetActive(false);
        count = count + 1;
        SetCountText ();
      }
    }

    void SetCountText()
    {
      countText.text = "Count: " + count.ToString ();
      if (count >= amountofcubes)
      {
        winText.text = "You Win!";
      }
    }

    void Jump()
    {
      LayerMask layer = 1 << gameObject.layer;
      layer = ~layer;
      isGrounded = Physics.CheckSphere(transform.position, 0.8f, layer);

      if (jump && isGrounded)
      {
        rb.AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
        rb.AddForce(Vector3.up * .8f, ForceMode.Impulse);
      }
    }

    private void OnCollisionEnter(Collision collision)
    {
      jumpDirection = collision.contacts[0].normal;
    }
}

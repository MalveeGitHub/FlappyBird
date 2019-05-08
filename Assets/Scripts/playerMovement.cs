using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  // Start is called before the first frame update
  public float speed;
  private Vector2 MoveVelocity;

  // Update is called once per frame
  void update()
  {
    // Vector2 MoveInput = new Vector2(0, 1);
    // MoveVelocity = MoveInput.normalized * speed;
  }
  void FixedUpdate()
  {
    GetComponent<Rigidbody2D>().AddForce(Vector2.right * 35 * Time.deltaTime);

    // Rigidbody2D rb = GetComponent<Rigidbody2D>();
    // rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);


    if (Input.GetKey("k"))
    {

      GetComponent<Rigidbody2D>().AddForce(Vector2.up * 70, ForceMode2D.Force);
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  // Start is called before the first frame update
  public AudioSource Source;
  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.collider.tag == "Ground")
      Source.Play();
  }
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}

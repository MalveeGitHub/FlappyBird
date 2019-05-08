using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
  public AudioSource Source;
  public AudioSource Source1;
  public ParticleSystem PlayerParticle;
  public GameObject PlayerPart;

  //Game Functionality
  private int HitCount;
  private int TotalHitCount = 10;
  public Text HitCountText;


  void start()
  {
    PlayerParticle.Stop();
  }
  private void OnCollisionEnter2D(Collision2D other)
  {
    //PlayerParticle.Play();
    if (other.collider.tag == "Enemy" || other.collider.tag == "RedEnemy" || other.collider.tag == "Wall" || other.collider.tag == "Ground")
    {
      if (HitCount < 10)
      {
        HitCount = HitCount + 2;
        string HitCountInfo = "HITCOUNT:" + HitCount + "/" + TotalHitCount;
        HitCountText.text = HitCountInfo;
        Debug.Log(HitCountInfo);
      }
      else
      {
        Debug.Log("Game Over");
        SceneManager.LoadScene("LoseScene");
      }
      //Debug.Log("Hit enemy");
      Source1.Play();
      //PlayerPart.SetActive(true);
    }
    else if (other.collider.tag == "Finish")
    {
      Debug.Log("Finish LIne");
      SceneManager.LoadScene("FinishScene");
    }
    else
    {
      Source.Play();
      //PlayerPart.SetActive(false);
    }
    
  }


  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.tag == "Heart")
    {
      Debug.Log("We Hit The heart");
      if(HitCount > 0)
      {
        HitCount = HitCount - 1;
        string HitCountInfo = "HITCOUNT:" + HitCount + "/" + TotalHitCount;
        HitCountText.text = HitCountInfo;
        collision.gameObject.SetActive(false);
      }
      
    }
  }
}

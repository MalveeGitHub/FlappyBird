using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealGameManager : MonoBehaviour
{
  public void OnStartClick()
  {
    SceneManager.LoadScene("Level1"); 
  }

  public void OnQuitClick()
  {
    Application.Quit();
  }

  public void OnRestartClick()
  {
    SceneManager.LoadScene("startMenu");
  }

  public void OnCheditsClick()
  {
    SceneManager.LoadScene("Credits");
  }
  public void OnBackClick()
  {
    SceneManager.LoadScene("startMenu");
  }
}

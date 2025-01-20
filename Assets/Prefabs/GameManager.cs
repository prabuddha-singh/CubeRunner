using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public GameObject completeLevel;
  bool GameHasEnded=false;
  public float RestartDelay=1f;
  public void EndGame(){
    if(GameHasEnded==false){

        GameHasEnded=true;
        Debug.Log("GAME OVER");
         Invoke("Restart",RestartDelay);
    }
    
  }

  void Restart(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void Win(){
    completeLevel.SetActive(true);
  }
}

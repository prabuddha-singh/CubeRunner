using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
   public void LoadNext(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}

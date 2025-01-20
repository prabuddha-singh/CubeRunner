using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
   void OnTriggerEnter(){//when trigger is set , dont use OnCollisionEnter()
      gameManager.Win();
   }
}

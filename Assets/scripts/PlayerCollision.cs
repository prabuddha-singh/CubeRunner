using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public PlayerMovement movement;
   void OnCollisionEnter(Collision info)
   {
      if(info.collider.tag == "Obstacle")
      {
         movement.enabled=false;
         FindAnyObjectByType<GameManager>().EndGame();
      }
   }
}

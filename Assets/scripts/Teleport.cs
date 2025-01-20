using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform TeleportTo;
    public Transform Player;
    
    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Player")){
           Player.transform.position=TeleportTo.transform.position;
        }
    }
}

using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}

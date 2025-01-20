using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform Player;
    public Vector3 offSet;
    void Update()
    {
        transform.position=Player.position + offSet;
    }
}

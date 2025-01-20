using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI Score;

    // Update is called once per frame
    void Update()
    {
        Score.text=(player.position.z+59.05).ToString("0");
    }
}

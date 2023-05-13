using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui : MonoBehaviour
{
    Player player;
    Spawner spawns;
    public TMP_Text Score;
    public TMP_Text Timer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Player>();
        spawns = GameObject.FindGameObjectWithTag("Spawn").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = player.score.ToString();
        Timer.text = spawns.currentTime.ToString("0");
    }
}

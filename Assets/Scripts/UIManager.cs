using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI updateTimer;
    public TextMeshProUGUI updateScore;
    public GameManager Gamemgr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void UpdateTimer(){
        updateTimer.text = Gamemgr.timer.ToString();
    }
    public void UpdateScore(int coleccionados){
        updateScore.text = "Score:" + coleccionados;
    }
}

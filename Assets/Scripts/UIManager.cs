using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI updateTimer;
    public TextMeshProUGUI updateScore;
    public GameManager Gamemgr;
    public GameObject panelWin;
    public GameObject panelGameOver;

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
        updateTimer.text = (Gamemgr.timer).ToString("F2");
    }
    public void UpdateScore(int coleccionados){
        updateScore.text = "Score:" + coleccionados;
    }
    public void MostrarPanelWin(){
        panelWin.SetActive(true);
    }
    public void MostrarPanelGameOver(){
        panelGameOver.SetActive(true);
    }
}

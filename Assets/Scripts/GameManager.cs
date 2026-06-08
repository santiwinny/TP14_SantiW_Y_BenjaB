using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float timer = 60f;
    public UIManager uimgr;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0) {
            timer = 0;
            uimgr.MostrarPanelGameOver();
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarEscena ();
        }
    }
     public void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
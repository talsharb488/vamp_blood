using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    private int dayLight; //timer till end of level
    private int score;
    private SceneManager smanager;
    private bool is_game_over = false;
    public bool isGameOver {
        get { return is_game_over; }
    }
       
    //victumWaveSpown;

	// Use this for initialization
	void Start () {
        dayLight = 100;
        is_game_over = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (dayLight==0)
            is_game_over = true;
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Refrence: I followed lecture 6 for this 

//The game Manager script literally managers the scripts that will be called within the UI 
//This script could have had all the UI stuff in it, but then it would get messy. By calling the other scripts within this script, things stay more organised 
namespace GameManagers
{

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;

    public int score;

    //below is serialised so we can see it in the UI but not in the different classes. Kinda like a private function but for classes 
    //It's calling the UI manager script 
    // it works by calling the class name, then the indivudual object name 
    [SerializeField] private UIManager uIManager;
 // [SerializeField] private AudioManager AudioManager; <- this isn't actually needed 

    private bool isPaused = false;

    // Awake is called before Start
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
    //    ResetScore(); <- not working yet 
        //Although this is refering to DP, I've called it score so far, so I'm going to keep calling it that

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddScore(10);
            //This will add 10 to the DP every time the space is pressed 

            //AddScore(dpclass);
            //Above is what I want it to do in theory, Just haven't set it up yet. I'll need to set up a DP class that can call the interger to the UI
            //By doing so, I can create another function to apply and effects that are on the DP as some cards add to it. This way you don't have to remember the maths 
        }   
        if(Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
            ///This calls the Pause menu when you press "p". I'll make a button for this later on
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
            //This will only work when the game is exported, not when in play mode
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            ResetScore();
        }
    }

    //Everything else 

    public void AddScore(int DP_Value)
    {
        score = DP_Value;
        uIManager.UpdateScoreDisplay(score);
        
        //AudioManager.Instance.PlaySoundEffect("ScoreSoundEffect");
        //You need to add a sound called sound effect for here. It probably won't work for what you plan to do, but it was part of the lecture 
    }
    public void ResetScore()
    {
        score = 0;
        uIManager.UpdateScoreDisplay(score);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        if(isPaused)
        {
            Time.timeScale = 0;
            //By setting this to 0 it stops the game loop of Update. Events will still run 
            AudioManager.Instance.PlaySoundEffect("Pause");
            //You need to add the name of the audio file you want for the pause menu where it says "Pause"

        }
        else
        {
            Time.timeScale = 1;
            //0 = off, 1 = on
            AudioManager.Instance.PlaySoundEffect("UnPause");
            //You need to add the name of the audio file you want for when unpausing the game
        }
        uIManager.TogglePauseMenu(isPaused);
        //Manages if UI elements will appear 
    }
        
}
}
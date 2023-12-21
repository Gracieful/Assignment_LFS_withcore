using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//refrence: Using Lecture 6. 
//I had also used some of the Vuforia Starter tools for the image decetion so the UI was already kind of created 
//I jsut couldn't see it oriignally as I had the play screen zoomed in 

//Added the rule section as I realised that might be needed for the game.

namespace GameManagers
{
public class UIManager : MonoBehaviour


{
    public TMP_Text scoreText;

  
    public GameObject pauseMenu;
    public GameObject Rules;

//I commented the score out when I thought I didn't need it anymoer and everything kinda broke so it's staying put
    public void UpdateScoreDisplay(int score)
    {
        scoreText.text = "DP:" + score;
    }
    //above will display the score value. 
    //Although the game itself will have damage values per digimon, 
    //this was part of the lecture so currently I'm following along to the tee and will alter later to suit what I need it to do 

    //I've updated this to say DP as I wan't ti to count the total DP of the digimon with any effects that may add extra DP to it 

    public void TogglePauseMenu(bool isPaused)
    {
        pauseMenu.SetActive(isPaused);
    }

        public void ToggleRuleMenu(bool isPaused)
    {
        Rules.SetActive(isPaused);
    }

}
}

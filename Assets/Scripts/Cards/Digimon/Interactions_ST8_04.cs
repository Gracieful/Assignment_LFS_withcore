using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//Refrences
//Image: https://digimoncard.io/card/veemon-st8-04
//Asset: https://www.models-resource.com/mobile/digimonlinkz/model/21287/


//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 
//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Digimon
//card name: Veemon
//DP: 2000
//Play Cost: 3
//Digivolve cost: Lvl2: 0
//Level: 3
//Effect: Your Turn: If your opponent has a level 6 or higher Digimon in play, this Digimon can digivole into an [UlforceVeedramon] in your hand for a memory cost of 4, ignoring it's digivolution requirements. 
//Effect: When Attacking: If you have 7 or fewer cards in your hand, trigger Draw 1. ( Draw 1 card from your deck.)

namespace Digimon
{

public class Interactions_ST8_04 : MonoBehaviour

{
     //Below I used the technique of displaying text as shown in lecture 6. 
    //I know I'll need to create another script that will work like the UI script but for calling all the digimon information
    //Currently not working as there needs to be code to call the text to display 
    public TMP_Text DPText;
    public TMP_Text NameText;
    public TMP_Text LevelText;
    public TMP_Text EffectText;
    public TMP_Text EvolutionText;
    public TMP_Text CostText;

    public void UpdateDPDisplay()
    {
        DPText.text = "DP:" + 2000;
    }

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Veemon";
    }
      public void UpdateLevelDisplay()
    {
        LevelText.text = "Level:" + "3";
    }
        public void UpdateEffectDisplay()
    {
        EffectText.text = "Effect:" + "Your Turn: If your opponent has a level 6 or higher Digimon in play, this Digimon can digivole into an [UlforceVeedramon] in your hand for a memory cost of 4, ignoring it's digivolution requirements." + "When Attacking: If you have 7 or fewer cards in your hand, trigger Draw 1. ( Draw 1 card from your deck.)";
    }
      public void UpdateEvolutionDisplay()
    {
        EvolutionText.text = "Digivolve cost:" + "Lvl2:0";
    }
        public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "3 Memory";
    }

    
//Using the below will make it so that all the text will update at once and I can add one function to Unity rather than 6
        public void Everything()
        {
            UpdateDPDisplay();
            UpdateNameDisplay();
            UpdateLevelDisplay();
            UpdateEffectDisplay();
            UpdateEvolutionDisplay();
            UpdateCostDisplay();
        }

        //copilot autofilled below. Honestly Copilot is a godsend.
        public void Lost()
        {
            DPText.text = "";
            NameText.text = "";
            LevelText.text = "";
            EffectText.text = "";
            EvolutionText.text = "";
            CostText.text = "";
        }
        // Start is called before the first frame update
        //  void Start()
        //{

        //}

        // Update is called once per frame
        //void Update()
        //{

        //}
}
}

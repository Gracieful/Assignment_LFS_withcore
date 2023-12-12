using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Refrences
//Image: https://digimoncard.io/card/Slayerdramon-st8-09#
//Asset: https://www.deviantart.com/lorisc93/art/Slayerdramon-978607843

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 

//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Digimon
//card name: Slayerdramon
//DP: 11000
//Play Cost: 11
//Digivolve cost: Lvl5: 3
//Level: 6
//Effect: When Digivolving: This Digimon gains Security Attack +1 for the turn. (This Digimon checks 1 additional Security card.)
//Effect:  Your Turn: This card is unblockable. 

namespace Digimon
{

public class Interactions_ST8_09 : MonoBehaviour

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
        DPText.text = "DP:" + 11000;
    }

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Slayerdramon";
    }
      public void UpdateLevelDisplay()
    {
        LevelText.text = "Level:" + "6";
    }
        public void UpdateEffectDisplay()
    {
        EffectText.text = "Effect:" + "When Digivolving: This Digimon gains Security Attack +1 for the turn. (This Digimon checks 1 additional Security card.)" + "Your Turn: This card is unblockable.";   
    }
      public void UpdateEvolutionDisplay()
    {
        EvolutionText.text = "Digivolve cost:" + "Lvl5:3";
    }
        public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "11 Memory";
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
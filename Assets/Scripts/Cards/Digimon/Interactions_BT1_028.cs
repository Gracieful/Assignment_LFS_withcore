using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Refrences
//Image: https://www.cardmarket.com/en/Digimon/Products/Singles/Starter-Deck-UlforceVeedramon/Elecmon-BT1-028-AA
//Asset: 

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 
//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Digimon
//card name: Elecmon
//DP: 3000
//Play Cost: 2 
//Digivolve cost: Lvl2: 0 
//Level: 3 
//Effect: -- 

namespace Digimon
{

public class Interactions_BT1_028 : MonoBehaviour

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

    public void UpdateDPDisplay(TMP_Text DPText)
    {
        DPText.text = "DP:" + 3000;
    }

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Elecmon";
    }
      public void UpdateLevelDisplay()
    {
        LevelText.text = "Level:" + "3";
    }
        public void UpdateEffectDisplay()
    {
        EffectText.text = "Effect:" + "--";
    }
      public void UpdateEvolutionDisplay()
    {
        EvolutionText.text = "Digivolve cost:" + "Lvl2:0";
    }
        public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "2 Memory";
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//For the asset I wasn't sure what to use so I created a partical system for it. The texture of the partical system is the card art.

namespace Option

{
public class Option_ST2_13 : MonoBehaviour

//Refrences
//Image: https://www.cardmarket.com/en/Digimon/Products/Singles/Starter-Deck-UlforceVeedramon/Hammer-Spark-ST2-13-AA
//Asset: 

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 

//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Option
//card name: Hammer Spark
//Play Cost: 0
//Main: Gain 1 Memory
//Effect:  Security: Gain 2 memory. 
{
    public TMP_Text NameText;
    public TMP_Text EffectText;
    public TMP_Text CostText;

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Hammer Spark";
    }

    public void UpdateEffectDisplay()
    {
        EffectText.text = "Main"+ "Gain 1 Memory" +"Effect:" + "Security: Gain 2 memory.";
    }
      public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "0 Memory";
    }
        public void Everything()
        {
            UpdateNameDisplay();
            UpdateEffectDisplay();
            UpdateCostDisplay();
        }
        //copilot autofilled below. Honestly Copilot is a godsend.
        public void Lost()
        {
            NameText.text = "";
            EffectText.text = "";
            CostText.text = "";
        }

}

}

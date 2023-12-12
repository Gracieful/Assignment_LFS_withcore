using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Option

{
public class Option_ST8_11 : MonoBehaviour

//Refrences
//Image: https://digimoncard.io/card/victory-sword-st8-11
//Asset: 

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 

//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Option
//card name: Victory Sword
//Play Cost: 3
//Main: Unsuspend 1 or yuour blue Digimon
//Effect:  Security: Add this card to it's owner's hand.
{
    public TMP_Text NameText;
    public TMP_Text EffectText;
    public TMP_Text CostText;

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Victory Sword";
    }

    public void UpdateEffectDisplay()
    {
        EffectText.text ="Main"+"Unsuspend 1 or yuour blue Digimon"+ "Effect:" + "Security: Add this card to it's owner's hand.";
    }
      public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "3 Memory";
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

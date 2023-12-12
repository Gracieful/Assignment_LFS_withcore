using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Option

{

public class Option_ST8_12 : MonoBehaviour

//Refrences
//Image: https://digimoncard.io/card/v-wing-blade-st8-12
//Asset: 

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 

//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Option
//card name: V-Wing Blade
//Play Cost: 6
//Main: Return 1 of your opponent's level 6 or lower Digimon to it's owner's hand. Trash all of the digivolutions cards of that Digimon.
//Effect:  Security: Activate this cards Main effect. 

{
    public TMP_Text NameText;
    public TMP_Text EffectText;
    public TMP_Text CostText;

     public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "V-Wing Blade";
    }
    public void UpdateEffectDisplay()
    {
        EffectText.text = "Main"+"Return 1 of your opponent's level 6 or lower Digimon to it's owner's hand. Trash all of the digivolutions cards of that Digimon."+"Effect:" + "Security: Activate this cards Main effect.";
    }
      public void UpdateCostDisplay()
    {
        CostText.text = "Play Cost:" + "6 Memory";
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

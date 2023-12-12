using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Given the way I've been calling the functions for the digimon, I probably don't need a namespace but it's better to be safe than sorry
//I might need it once more cards get added 

namespace Egg


{
public class Egg_Interactions_ST2_01 : MonoBehaviour

//Refrences
//Image: https://digimoncard.io/card/tsunomon-st2-01
//Asset: https://www.models-resource.com/mobile/digimonlinkz/model/21385/

//There's different types of cards in the digimon TCG. Eggs, Monsters, Options, Tamers Trainers. 
//I'm 100% sure how to use the classes so I have it commented out for now just in case 

//I've also included all the card data as a comment before I've figured out where it needs to go 

//public class Egg
//card name: Tsunomon
//Level: 2 
//Effect: Your Turn: This Digimon gets +1000 Dp when battling an opponents Digimon that has no digivolution cards
{
    public TMP_Text NameText;
    public TMP_Text LevelText;
    public TMP_Text EffectText;
    public void UpdateNameDisplay()
    {
        NameText.text = "Name:" + "Tsunomon";
    }

    public void UpdateLevelDisplay()
    {
        LevelText.text = "Level:" + "2";
    }

    public void UpdateEffectDisplay()
    {
        EffectText.text = "Effect:" + "Your Turn: This Digimon gets +1000 Dp when battling an opponents Digimon that has no digivolution cards";
    }
        public void Everything()
        {
            UpdateNameDisplay();
            UpdateLevelDisplay();
            UpdateEffectDisplay();
        }
        //copilot autofilled below. Honestly Copilot is a godsend.
        public void Lost()
        {
            NameText.text = "";
            LevelText.text = "";
            EffectText.text = "";
        }
        
//{
    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

    // Update is called once per frame
//    void Update()
//    {
        
//   }
//}
}
}
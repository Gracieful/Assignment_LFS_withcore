using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

namespace Digimon
{


public class DigimonManager : MonoBehaviour
{
    public static DigimonManager Instance;
    public TMP_Text NameText;
    public TMP_Text LevelText;
    public TMP_Text EffectText;
    public TMP_Text EvolutionText;
    public TMP_Text CostText;
    //Had below to make the info box appear and dissapear but it didn't work
    //private bool isAppearing = false;
     
    //I'm going to have to do the below for every digimon xD  
    //Will probably need another one for eggs, options and trainers
    [SerializeField] private Interactions_BT1_028  Elecmon_BT1_028;
    [SerializeField] private Interactions_BT1_037  Gorillamon_BT1_037;
    [SerializeField] private Interactions_BT1_038  Monzaemon_BT1_038;
    [SerializeField] private Interactions_ST2_02  Gomamon_ST2_02;
    [SerializeField] private Interactions_ST2_03  Gabumon_ST2_03 ;
    [SerializeField] private Interactions_ST8_02  Gabumon_ST8_02;
    [SerializeField] private Interactions_ST8_03  Dracomon_ST8_03;
    [SerializeField] private Interactions_ST8_04 Veemon_ST8_05;
    [SerializeField] private Interactions_ST8_05  Veedramon_ST8_05;
    [SerializeField] private Interactions_ST8_06  Coredramon_ST8_06;
    [SerializeField] private Interactions_ST8_07  Wingdramon_ST8_07;
    [SerializeField] private Interactions_ST8_08  AeroVeedramon_ST8_08;
    [SerializeField] private Interactions_ST8_09 Slayerdramon_ST8_09;
    [SerializeField] private Interactions_ST8_10 UlforceVeedramon_ST8_10;
//Gorillamon doesn't work
//Monzaemon doesn't work either. Keep getting the same error where instance is not set to an object 
//Maybe it's an asset issue? It wasn't
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            DisplayName();
            DisplayDP();
            DisplayCost();
            DisplayEvolution();
            DisplayLevel();
            DisplayEffectText();
            //below doesn't work but I was playing with getting the info box to appear and dissapear when called 
           // ToggleInfo(Elecmon_BT1_028.Info_Elecmon);
    
            
            
            //This will only get the text from Elecmon to display, but when card appears on screen. Works as a tester
            //I'll need to create a variable that captures the card being picked up that will fill in where the card name is 
        }  

//Got the below from co-pilot after asking it to check the following error "NullReferenceException: Object reference not set to an instance of an object Digimon.DigimonManager.Update () (at Assets/Scripts/GameManagers/DigimonManager.cs:67)"
 //       if (NameText != null)
 //       {
 //           Elecmon_BT1_028.NameText = NameText;
 //       }
 //       else
 //       {
 //           Debug.LogWarning("Name Error");
 //       }

            //changed below to DisplayName1 as I was getting an ambigous error. Below was to test if gorrillamon could be called
            //currently it can't. Could it be because it's got the same names as Elecmon? 

// else works but is commented out because it would keep the error appearing in the scrip when E wasn't pressed 

 //       else
 //       {
 //           Debug.LogWarning("DP Error");
            
 //       }

    }
//Changed the asset for elecmon and now it's broken and I'm getting the same error as gorillamon. So I'm assuming it's asset related 
//The reason it broke when i updated the asset is because I had the assets connected to the manager in Unitys UI. 
//The reason nothing else was working, was because I had nothing else connected. 

    //Everything else 
        public void DisplayName()
    {
        Gorillamon_BT1_037.UpdateNameDisplay();
    }
        public void DisplayLevel()
    {
        Gorillamon_BT1_037.UpdateLevelDisplay();
    }
        public void DisplayCost()
    {
        Gorillamon_BT1_037.UpdateCostDisplay();
    }
        public void DisplayEvolution()
    {
        Gorillamon_BT1_037.UpdateEvolutionDisplay();
    }
          public void DisplayEffectText()
    {
        Gorillamon_BT1_037.UpdateEffectDisplay();
    }
           public void DisplayDP()
    {
        Elecmon_BT1_028.UpdateDPDisplay();
   
    }
//        public void ToggleInfo(GameObject Info_Elecmon)
  //  {
//        Elecmon_BT1_028.ToggleInfo(isAppearing);
//    }


}
}

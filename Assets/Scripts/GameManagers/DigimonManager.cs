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
            DisplayDP(Elecmon_BT1_028.DPText);
            DisplayName(Elecmon_BT1_028.NameText);
            DisplayLevel(Elecmon_BT1_028.LevelText);
            DisplayEffectText(Elecmon_BT1_028.EffectText);
            DisplayEvolution(Elecmon_BT1_028.EvolutionText);
            DisplayCost(Elecmon_BT1_028.CostText);
            //This will only get the text from Elecmon to display, but when card appears on screen. Works as a tester
            //I'll need to create a variable that captures the card being picked up that will fill in where the card name is 
        }  
        else
        {
            Debug.LogWarning("DP Error");
            
        }
        
    }
    //Everything else 
   
        public void DisplayDP(TMPro.TMP_Text DPText)
    {
        Elecmon_BT1_028.UpdateDPDisplay(DPText);
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }
        public void DisplayName(TMPro.TMP_Text NameText)
    {
        Elecmon_BT1_028.UpdateNameDisplay();
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }
        public void DisplayLevel(TMPro.TMP_Text LevelText)
    {
        Elecmon_BT1_028.UpdateLevelDisplay();
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }
         public void DisplayEffectText(TMPro.TMP_Text EffectText)
    {
        Elecmon_BT1_028.UpdateEffectDisplay();
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }
        public void DisplayEvolution(TMPro.TMP_Text EvolutionText)
    {
        Elecmon_BT1_028.UpdateEvolutionDisplay();
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }
        public void DisplayCost(TMPro.TMP_Text CostText)
    {
        Elecmon_BT1_028.UpdateCostDisplay();
        //elecmon is the only digimon I have eveything set up for. Getting him to work before testing everything to work
    }


}
}

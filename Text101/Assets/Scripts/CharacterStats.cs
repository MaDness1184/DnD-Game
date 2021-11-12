using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public GameObject charStatsPanel;
    public Text statsTxt;

    public Stat acrobatics;
    public Stat athletics;
    public Stat charisma;
    public Stat deception;
    public Stat dexterity;
    public Stat intuition;
    public Stat perception;
    public Stat persuasion;
    public Stat stealth;
    public Stat strength;
    public Stat wisdom;

    void Start()
    {
        statsTxt.text = "Acrobatics: " + acrobatics.finalStat +
            "\nAthletics: " + athletics.finalStat +
            "\nCharisma: " + charisma.finalStat +
            "\nDeception: " + deception.finalStat +
            "\nDexterity: " + dexterity.finalStat +
            "\nIntuition: " + intuition.finalStat +
            "\nPerception: " + perception.finalStat +
            "\nPersuasion: " + persuasion.finalStat +
            "\nStealth: " + stealth.finalStat +
            "\nStrength: " + strength.finalStat +
            "\nWisdom: " + deception.finalStat;   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (charStatsPanel.activeInHierarchy)
            {
                Debug.Log("Stats Closed");
                charStatsPanel.SetActive(false);
            }
            else
            {
                Debug.Log("Stats Opened");
                charStatsPanel.SetActive(true);
            }
        }
    }
}

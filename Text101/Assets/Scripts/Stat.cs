using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Stat")]
public class Stat : ScriptableObject
{
    public int finalStat = 0;
    public string statName;
    public int statNum;
    private int lucky;
    private int buff;
    private int superBuff;

    // Start is called before the first frame update
    void OnEnable()
    {
        finalStat = StatGen();
        Debug.Log("Character Stat " + statName + " is set to: " + finalStat);
    }

    public int StatGen()
    {
        statNum = Random.Range(0, 3);
        lucky = Random.Range(1, 11);
        buff = Random.Range(1, 4);
        superBuff = Random.Range(2, 5);

        if (lucky >= 8)
        {
            statNum += superBuff;
        }
        else if (lucky >= 6)
        {
            statNum += buff;
        }

        return statNum;
    }
}

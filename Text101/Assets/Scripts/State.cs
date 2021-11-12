using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14, 14)] public string storyText;
    public State[] nextStates;
    public bool atribute;
    public Stat atributeStat;

    public Stat GetStat()
    {
        return atributeStat;
    }

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    public Text textComponent;
    public State startingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.atribute == true)
        {
            AtributeChoice();
        }
        else
        {
            ManageState();
        }
    }

    // Mutate the state
    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        textComponent.text = state.GetStateStory();
    }

   // Stat Roll
    private bool ResultGen()
    {
        int roll = 0;
        Stat chance = state.GetStat();
        int num = chance.finalStat;
        bool pass = false;

        if (num == 7)
        {
            roll = 16;
        }
        else if (num <= 2 && num != 0)
        {
            roll = Random.Range(8, 20);
        }
        else if (num == 3)
        {
            roll = Random.Range(10, 20);
        }
        else if (num == 4)
        {
            roll = Random.Range(12, 20);
        }
        else if (num == 5)
        {
            roll = Random.Range(14, 20);
        }
        else if (num == 6)
        {
            roll = Random.Range(15, 20);
        }
        else
        {
            roll = 0;
        }

        if (roll >= 15)
        {
            Debug.Log("Attempt Passed! " + roll);
            pass = true;
        }
        else
        {
            Debug.Log("Attempt Failed! " + roll);
        }
        return pass;
    }

    // If there is an atribute involved in the choice
    private void AtributeChoice()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Option 1 Selected");
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && !ResultGen())
        {
            Debug.Log("Option 2 Selected");
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && ResultGen())
        {
            Debug.Log("Option 2 Selected");
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}

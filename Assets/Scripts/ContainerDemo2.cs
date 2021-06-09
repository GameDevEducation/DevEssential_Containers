using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerDemo2 : MonoBehaviour
{
    public string Difficulty = "Medium";

    Dictionary<string, int> HealthValuesPerDifficulty = new Dictionary<string, int>();
    Dictionary<string, float> SpeedModifiersPerDifficulty = new Dictionary<string, float>();

    // Start is called before the first frame update
    void Start()
    {
        // setup our health values
        HealthValuesPerDifficulty["Easy"] = 500;
        HealthValuesPerDifficulty["Medium"] = 250;
        HealthValuesPerDifficulty["Hard"] = 100;
        HealthValuesPerDifficulty["Why?!?"] = 1;

        // setup our speed modifiers
        SpeedModifiersPerDifficulty["Easy"] = 0.25f;
        SpeedModifiersPerDifficulty["Medium"] = 0.75f;
        SpeedModifiersPerDifficulty["Hard"] = 1.5f;
        SpeedModifiersPerDifficulty["Why?!?"] = 10f;

        // this line will modify the health for the selected difficulty
        // HealthValuesPerDifficulty[Difficulty] = 10000;

        // this line will cause an error because it removes the difficulty we are about to read from
        //HealthValuesPerDifficulty.Remove(Difficulty);

        Debug.Log("The HP for " + Difficulty + " is " + HealthValuesPerDifficulty[Difficulty] + " and the speed is " + SpeedModifiersPerDifficulty[Difficulty]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

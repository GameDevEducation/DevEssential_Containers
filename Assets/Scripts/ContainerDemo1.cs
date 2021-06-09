using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerDemo1 : MonoBehaviour
{
    public List<string> FirstNames;
    public List<string> LastNames;

    public int[] StartingHealthValues;

    List<string> ChosenNames = new List<string>();
    int[] ChosenHealthValues = new int[4];

    // Start is called before the first frame update
    void Start()
    {
        // run validity/safety check on the first names
        if (FirstNames.Count == 0)
        {
            Debug.LogError("No first names have been setup");
        }

        // run validity/safety check on the last names
        if (LastNames.Count == 0)
        {
            Debug.LogError("No last names have been setup");
        }

        // Pick a random first name and remove from list
        string selectedFirstName = FirstNames[Random.Range(0, FirstNames.Count)];
        FirstNames.Remove(selectedFirstName);

        // Pick a random last name and remove from list
        int selectedLastNameIndex = Random.Range(0, LastNames.Count);
        string selectedLastName = LastNames[selectedLastNameIndex];
        LastNames.RemoveAt(selectedLastNameIndex);
        
        Debug.Log("Name is " + selectedFirstName + " " + selectedLastName);

        // store the selected name
        ChosenNames.Add(selectedFirstName + " " + selectedLastName);
        Debug.Log("We have selected " + ChosenNames.Count + " names");

        // pick a random starting health
        int startingHealth = StartingHealthValues[Random.Range(0, StartingHealthValues.Length)];
        Debug.Log("Starting health is " + startingHealth);

        // store the starting health
        ChosenHealthValues[0] = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

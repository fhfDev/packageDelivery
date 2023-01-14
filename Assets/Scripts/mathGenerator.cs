using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathGenerator : MonoBehaviour
{
    public Text txt;
    public InputField result;

    void Start()
    {
        string[] problems = new string[]                    // source: https://cloud-0.edupage.org/cloud/kladne_a_zaporne_cisla.pdf?z%3ALpY%2B0y5zUqIxqqmF56W5kbMiRw6Gar1IjopTiAJhH5aHBEDoqaH2LRaAkmqUpfUv
        {
            "1 - (-6)",
            "- 8 + (+ 5)",
            "- 2 + (+ 10)",
            "- 3 + (-5)",
            "(- 2) * 9",
            "10 / (-5)",
            "10x - 4"
        };
        string[] possibleResults = new string[] {"10", "20", "30", "40"};
        System.Random random = new System.Random();
        int useProblem = random.Next(problems.Length);
        string selectedProblem = problems[useProblem]; 
        txt.text = selectedProblem.ToString();              // Debug.Log(selectedProblem);  
        /*if(result.text.Equals(possibleResults))
        {
            Debug.Log("OK");
        }
        Debug.Log("Zly vysledok"); */
    }
}
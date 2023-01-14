using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mathGenerator : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private InputField result;
    
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
            "10x - 4",
            "(+ 4) + (+ 41)",
            "- 12 + 12",
            "(- 5) + (- 15)"
        };
        string[] possibleResults = new string[] {"10", "20", "30", "40"};
        System.Random random = new System.Random();
        textComponent = GetComponent<TextMeshProUGUI>();

        int useProblem = random.Next(problems.Length);
        string selectedProblem = problems[useProblem];
        textComponent.text = selectedProblem.ToString();   // Debug.Log(selectedProblem);

        /*
            if(result.text.Equals(possibleResults))
            {
                Debug.Log("OK");
            }
            Debug.Log("Zly vysledok"); 
        */
    }
}
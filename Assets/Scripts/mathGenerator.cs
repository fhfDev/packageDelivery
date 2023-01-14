using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class mathGenerator : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TMP_InputField inputComponent;
    private string result;
    
    public void Start()
    {
        string[] problems = new string[]    // source: https://cloud-0.edupage.org/cloud/kladne_a_zaporne_cisla.pdf?z%3ALpY%2B0y5zUqIxqqmF56W5kbMiRw6Gar1IjopTiAJhH5aHBEDoqaH2LRaAkmqUpfUv
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
            "(- 5) + (-15)"
        };

        System.Random random = new System.Random();
        textComponent = GetComponent<TextMeshProUGUI>();
        int useProblem = random.Next(problems.Length);
        string selectedProblem = problems[useProblem];
        textComponent.text = selectedProblem.ToString();   // Debug.Log(selectedProblem);
        AssignResult(selectedProblem);
    }

    void Update()
    {
        if (string.Compare(inputComponent.text.ToString(),result) == 0)
        {
            // tu bude cast kodu co sa ma vykonat ked je vysledok spravny
        }

        // tu bude cast kodu co sa ma vykonat ked je vysledok nespravny
    }

    void AssignResult(string problem)
    {
        switch (problem)
        {
            case "1 - (-6)":
            {
                result = "7";
                break;
            }

            case "- 8 + (+ 5)":
            {
                result = "-3";
                break;
            }

            case "- 2 + (+ 10)":
            {
                result = "8";
                break;
            }

            case "- 3 + (-5)":
            {
                result = "-8";
                break;
            }

            case "(- 2) * 9":
            {
                result = "-18";
                break;
            }

            case "10 / (-5)":
            {
                result = "-2";
                break;
            }

            case "10x - 4":
            {
                result = "70";
                break;
            }

            case "(+ 4) + (+ 41)":
            {
                result = "45";
                break;
            }

            case "- 12 + 12":
            {
                result = "0";
                break;
            }

            case "(- 5) + (-15)":
            {   
                result = "-20";
                break;
            }
        }
    }
}
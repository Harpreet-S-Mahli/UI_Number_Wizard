using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;

    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min= guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess -1;
        NextGuess();
    }

    public void NextGuess()
    {
        //Because now the variables aren't hard coded, but rather intialized outside of the code, the guess can't be 
        //hardcoded as well, needs to now calculate whatever int it gets for min and max
        guess = Random.Range(min, max + 1);

        //Need to convert the int to a string cause our text field is looking for a string to display, not a int
        guessText.text = guess.ToString();
    }
}

/* Source: Example Code for Game Programming Design Patterns by  Owen Schaffer
 * George Tang
 * Assignment 3
 * DisplayText.cs
 * using Data from the user in textbox to check if answer is correct. Allows the user to play again.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace ObserverPatternText
{
    //Attach this class to a UI text object to display the text
    public class DisplayText : MonoBehaviour, IObserver
    {
        //Attach the GameObject holding TextData to this reference in the inspector
        public TextData textData;
        public Text winText;
        public static bool gameOver = false;
        public static bool won = false;
        public static string correctAnswer = "Tesla";
        private string textToDisplay;
        
        void Start()
        {
            won = false;
            gameOver = false;
            this.textToDisplay = " ";
            this.textToDisplay = gameObject.GetComponent<Text>().text;

            textData.RegisterObserver(this);
        }

        public void UpdateData(string text)
        {
            this.textToDisplay = text;
            gameObject.GetComponent<Text>().text = this.textToDisplay;
        }

        void Update()
        {
            if (!gameOver)
            {
                winText.text = " ";
            }
            if (textToDisplay == correctAnswer)
            {
                won = true;
                gameOver = true;
            }
            
            

            if (gameOver)
            {
                if (won)
                {
                    winText.text = "Answer is Correct! Press R to try again";
                }
                else
                {
                    winText.text = "Answer is incorrect Press R to try again";
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}

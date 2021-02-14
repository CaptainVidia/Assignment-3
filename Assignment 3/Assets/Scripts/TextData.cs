/* Source: Example Code for Game Programming Design Patterns by  Owen Schaffer
 * George Tang
 * Assignment 3
 * TextData.cs
 * using methods from ISubject to remove, register notify, and setting text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to add this using statement
using UnityEngine.UI;

namespace ObserverPatternText
{
    //Attach this class to an InputField GameObject in the scene
    public class TextData : MonoBehaviour, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
       
        private string text;
        string correctAnswerText  = "Tesla";

        public bool correctAnswer;

        //Attach the InputField GameObject where the user types in 
        //the text to this in the inspector
        public GameObject inputField;
        private object anwser;

        public void RegisterObserver(IObserver observer)
        {
            //Add observer to list of observers
            observers.Add(observer);

            //Updates data for newly added observer
            observer.UpdateData(text);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
                
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                //include data as parameters to UpdateData
                observer.UpdateData(text);
                //observer.CheckAnswer(anwser);
                Debug.Log("UpdateData was called from Notify Observers");
                
            }
        }

        //This method must be called by Unity, such as by calling 
        //it when a Submit button is pressed
        public void setText()
        {
            this.text = inputField.GetComponent<Text>().text;
            NotifyObservers();
        }

        
    }
}

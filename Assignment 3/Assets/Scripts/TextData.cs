/* George Tang
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
    public class TextData : MonoBehaviour, IQuiz
    {
        private List<IObserver> observers = new List<IObserver>();
        private string text;
        public GameObject inputField;
        private object anwser;

        public void RecordObserver(IObserver observer)
        {
            
            observers.Add(observer);
            observer.UpdateData(text);
        }

        public void DeleteObserver(IObserver observer)
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
                
                observer.UpdateData(text);
                Debug.Log("UpdateData was called from Notify Observers");
                
            }
        }
        
        public void setText()
        {
            this.text = inputField.GetComponent<Text>().text;
            NotifyObservers();
        }

        
    }
}

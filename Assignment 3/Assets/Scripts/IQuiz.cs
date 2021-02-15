/* George Tang
 * Assignment 3
 * ISubject.cs
 * ObserverPatternText creates a interface and method for Register Remove and Notify
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternText
{

    public interface IQuiz
    {
        void RecordObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObservers();
    }


}
/* Source: Example Code for Game Programming Design Patterns by  Owen Schaffer
 * George Tang
 * Assignment 3
 * ISubject.cs
 * ObserverPatternText creates a interface and method for Register Remove and Notify
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternText
{

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }


}
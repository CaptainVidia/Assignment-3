/* George Tang
 * Assignment 3
 * IObserver.cs
 * ObserverPatternText creates a interface and method for UpdateData
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternText
{
    public interface IObserver
    {
        void UpdateData(string text);
        
    }
}

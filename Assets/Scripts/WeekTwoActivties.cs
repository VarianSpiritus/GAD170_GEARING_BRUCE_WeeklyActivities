using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BruceGearing
{
    public class WeekTwoActivties : MonoBehaviour
    {
       
        // Information about my favourite game (name hours played and cost)
        private string favouriteGame = "Warframe"; 
        private int hoursPlayed = 160;
        private float cost = 360.95f;

        // Start is called before the first frame update
        void Start()
        {
            // + add
            // - substract
            // / divide
            // * multiply
            float dollarsPerHour;
            dollarsPerHour = cost / hoursPlayed;

            Debug.Log("My Favourite game is " + favouriteGame + " I have played it for " + hoursPlayed + " hours, and it cost me $" + cost + ". Therefore, my value of dollars per hour is: $" + dollarsPerHour); 
        }

        // Update is called once per frame
        
        void Update()
        {
            
        }

   
    }
}

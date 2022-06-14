using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BruceGearing
{
    public class WeekThreeActivities : MonoBehaviour
    {
        //Information about my name it prints my first and last name
        public int playerStrength;
        public int playerAgility;
        public int playerIntelligence;
        public float powerLevelPlayerOne;
        public float powerLevelPlayerTwo;

        // Start is called before the first frame update
        void Start()
        {
            playerStrength = Random.Range; (1, 11);
            playerAgility = Random.Range; (1, 11);
            playerIntelligence = Random.Range; (1, 11);
            powerLevelPlayerOne = playerStrength * 2 + playerAgility * 1.5f + playerIntelligence;
            powerLevelPlayerTwo = playerStrength * 2 + playerAgility * 1.5f + playerIntelligence;

            if (powerLevelPlayerOne > powerLevelPlayerTwo)
            {
                Debug.Log("Player 1 Wins");
            }

            else
            {
                Debug.Log("Player2 wins");
            }



        }

        void PowerLevel(int playerStrength, int playerAgility, int playerIntelligence)
        {
            int result = 0;
            result = (int)(playerStrength * 2 + playerAgility * 1.5f + playerIntelligence);


        }

        // Update is called once per frame
        void Update()
        {

        }


    }
}

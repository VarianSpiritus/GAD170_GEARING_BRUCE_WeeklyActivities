using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{
    // public float for the year and temperature (Bruce)
    public float year = 0;
    public float temperature = 75;


    // Start is called before the first frame update
    void Start()
    {
        year =(Random.Range(0, 2023));

        if (year % 4 == 0 )
            Debug.Log("Is a leap year!" + year);


        else
        {
            Debug.Log("Is not a leap year!");
        }

        temperature = (temperature - 32 * 5 / 9);
        {
           
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

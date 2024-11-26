using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = false;
   





    void Start()
    {
        Debug.Log("The car model is " + carModel + " with an engine type of " + engineType + ".");

    }

     
    
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            Debug.Log(carModel + " weighs less than 1500 kg.");
        }
        else
        {
            Debug.Log(carModel + " weighs over 1500 kg.");
        }

        CheckWeight();

    
        if (yearMade <= 2009)
        {
            Debug.Log(carModel + " was introduced in the year " + yearMade + ".");

            
            int carAge = CalculateAge(yearMade);

           
            Debug.Log(carModel + " is " + carAge + " years old.");
        }
        else
        {
           
            Debug.Log(carModel + " was introduced in the 2010’s.");

        }
        int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;

         string CheckCharacteristics()
            {
                if (isCarTypeSedan)
                {
                    return "The car type is a sedan.";
                }
                else if (hasFrontEngine)
                {
                    return "The car isn’t a sedan, but it has a front engine.";
                }
                else
                {
                    return "The car is neither a sedan nor does it have a front engine.";
                }
            }
        }

     
    
    void Update()
        {

        }
}

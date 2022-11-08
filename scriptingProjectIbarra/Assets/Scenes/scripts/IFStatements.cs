using UnityEngine;
using System.Collections;

public class IFStatement : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldlimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDowwn(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        //if the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotlimitTemperature)
        {
            //...do this.
            print("coffee is too hot");
        }
        //If it isn't, but the coffee temperature is less than the coldest drink temperture...
        else if (coffeeTemperature < coldlimitTemperatureLimit)
        {
            //... do this.
            print("coffee is just too cold.");
        }
        //If it is neither of those then...
        else
        {

        }
    }
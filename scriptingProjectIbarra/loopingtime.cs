using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}

using UnityEngine;
using System.Collection

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;


    void start()
    {
        for (int 1 = 0; int < numEnemies; int++)
        {
            debug.log("Creating enemy number: " + 1);
        }
    }
}

using UnityEngine;
Using System.Collections;

public class DoWhileloop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("hello World");

        } while (shouldContinue == true);
    }
}
 using UnityEngine;
 using system.Collections;

public class ForeachLoop : MonoBehaviour
{
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}

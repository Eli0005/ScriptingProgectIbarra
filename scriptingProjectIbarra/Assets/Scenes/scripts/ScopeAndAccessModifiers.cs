using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;


    private AnotherClass my0therClass;


    void start()
    {
        alpha = 29;

        my0therClass = new AnotherClass();
        myOtherClass.Fruitmachine(alpha, my0therClass.apples);
    }


    void Example(int pens, int crayons)
    {
        int answer = pens * crayons * alpha;
        debug.log(answer);
    }


    void update ()
    { 
        debug.log("Alpha is set to: " + alpha)
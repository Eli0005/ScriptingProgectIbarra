using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.log("I've washed a cup!");


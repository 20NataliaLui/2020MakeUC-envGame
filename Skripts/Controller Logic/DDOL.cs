using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Only to Instatiate Singleton Pattern
public class DDOL : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("DDOL " + gameObject.name);
    }
}

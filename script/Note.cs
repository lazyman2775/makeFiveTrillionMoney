using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    GameDirector gamedirectorVariable;
    
    // Start is called before the first frame update
    void Start()
    {
        gamedirectorVariable = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

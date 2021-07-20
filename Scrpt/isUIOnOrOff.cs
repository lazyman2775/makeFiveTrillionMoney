using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isUIOnOrOff : MonoBehaviour
{
   public GameObject map1;
    public GameObject map2;
    private int a;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update(){
        if(Input.GetMouseButtonDown(1)){
            map1.SetActive(false);
            map2.SetActive(false);
        }
    }
    public void Active(){
        map2.SetActive(true);
        map1.SetActive(true);
    }
    // Update is called once per frame
}

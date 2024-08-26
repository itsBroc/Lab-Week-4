using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{ 
    private int i = 3;
    public Renderer rend;
    private int blueDeactivate;

    // Start is called before the first frame update
    void Start()
    {
        blueDeactivate = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log($"{gameObject.name}:{i}");
        if(tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if(tag == "Blue" && i == blueDeactivate)
        {
            rend.enabled = false;
        }
        
    }
}

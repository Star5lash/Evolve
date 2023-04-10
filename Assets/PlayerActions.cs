using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    private bool canCustomize;
    // Start is called before the first frame update
    void Start()
    {
        DisableCustomize();
    }

    // Update is called once per frame
    void Update()
    {
        if (canCustomize)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("customize");
            }
        }
    }

    public void EnableCustomize()
    {
        if (!canCustomize)
        {
            canCustomize = true;
        }
    }

    public void DisableCustomize()
    {
        if (canCustomize)
        {
            canCustomize = false;
        }
    }
}

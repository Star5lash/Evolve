using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        GameObject go = col.gameObject;
        if (go.name == "Player")
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
            go.GetComponent<PlayerActions>().EnableCustomize();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject go = other.gameObject;
        if (go.name == "Player")
        {
            this.GetComponent<SpriteRenderer>().color = new Color(0.7924528f, 0.5238231f, 0.1532574f);
            go.GetComponent<PlayerActions>().DisableCustomize();
        }
    }
}

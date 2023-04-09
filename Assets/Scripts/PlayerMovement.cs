using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;

    private Vector3 mousePosInGameWorld;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosInGameWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(mousePosInGameWorld, Vector3.forward);
        transform.eulerAngles = new Vector3(0,0,-transform.eulerAngles.z);
        transform.Translate(Vector3.up*Time.deltaTime*speed);
        Camera.main.transform.eulerAngles = new Vector3(0,0,0);
    }
}

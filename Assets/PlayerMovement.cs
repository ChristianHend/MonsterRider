using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private bool runActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(runActive)
        {
            gameObject.transform.position += Vector3.right * Time.deltaTime;  

        }
    }

    public void StartRun()
    {
        runActive = true;
        //Speed to the right
    }
}

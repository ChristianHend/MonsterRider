using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameEventManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    PlayerMovement playerMovement;
    void Awake()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMovement.StartRun();


        }
    }
}

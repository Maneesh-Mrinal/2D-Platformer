using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private PlayerMovement player;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
    }
        
    public void RespawnPlayer()
    {
        Debug.Log("PLayer Respawn");    
        player.transform.position = currentCheckpoint.transform.position;
    }
    
}

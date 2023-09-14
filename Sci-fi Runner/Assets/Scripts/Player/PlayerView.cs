using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;
    public void SetPlayerController(PlayerController Controller)
    {
        this.playerController = Controller;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Movement()
    {

    }
    private void shoot()
    {

    }
    private void Death()
    {

    }
    private void Collect()
    {

    }
    private bool OnFloor()
    {
        return true;
    }
}

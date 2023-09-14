using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private PlayerController playerController;

    private int health { get; set; }
    private int speed { get; set; }
    private float RotationSpeed { get; set; }

    public PlayerModel()
    {
        
    }
    public void SetPlayerController(PlayerController Controller)
    {
        this.playerController = Controller;
    }
}

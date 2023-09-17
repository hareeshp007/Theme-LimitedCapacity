using Game.player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoSingletonGeneric<PlayerService>
{
    //
    [SerializeField]
    private PlayerView playerPrefab;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private PlayerView playerView;
    [SerializeField]
    private PlayerModel playerModel;
    protected override void Awake()
    {
        base.Awake();
        CreateTank();
    }

    private void CreateTank()
    {
        this.playerModel = new PlayerModel();
        this.playerView = GameObject.Instantiate<PlayerView>(playerPrefab);
        this.playerController = new PlayerController(playerView,playerModel);
    }

    public PlayerView GetPlayer()
    {
        return this.playerView;
    }
}

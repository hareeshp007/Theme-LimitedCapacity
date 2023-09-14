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
        int tankIndex = UnityEngine.Random.Range(0, PlayerConfig.playerObjects.Length);
        this.playerObject = PlayerConfig.tankObjects[tankIndex];
        CreateTank();
    }

    private void CreateTank()
    {
        this.playerModel = new PlayerModel();
        this.playerView = GameObject.Instantiate<PlayerView>(playerPrefab);
        this.playerController = new PlayerController();
    }
}

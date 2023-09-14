using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerModel _Model;
    private PlayerView _View;
    PlayerController(PlayerView playerView,PlayerModel playerModel) 
    {
        _Model = playerModel;
        _View = playerView;
    }

}

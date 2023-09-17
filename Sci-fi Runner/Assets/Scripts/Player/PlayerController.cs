namespace Game.player
{
    public class PlayerController
    {
        private PlayerModel _Model;
        private PlayerView _View;

        private int speed;
        public PlayerController(PlayerView playerView, PlayerModel playerModel)
        {
            _Model = playerModel;
            _View = playerView;
            _Model.SetPlayerController(this);
            _View.SetPlayerController(this);
            speed = _Model.speed;
        }

        public void TakeDamage(int damage)
        {
            int health = _Model.health;
            if (health - damage > 0)
            {
                health -= damage;
            }
            else
            {
                Death();
            }
        }
        public void Death()
        {

        }
        public void Movement()
        {

        }
    }
}


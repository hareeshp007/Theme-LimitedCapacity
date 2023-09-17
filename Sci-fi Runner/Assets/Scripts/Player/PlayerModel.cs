namespace Game.player
{
    public class PlayerModel
    {
        private PlayerController playerController;

        public int health { get; private set; }
        public int speed { get; private set; }
        private float RotationSpeed { get; set; }

        public PlayerModel()
        {

        }
        public void SetPlayerController(PlayerController Controller)
        {
            this.playerController = Controller;
        }
        public int SetHealth(int _health)
        {
            health = _health;
            return health;
        }
        public int SetSpeed(int _speed)
        {
            speed = _speed;
            return speed;
        }
    }
}


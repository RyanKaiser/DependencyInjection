namespace DI3
{
    public class Player : MonoBehaviour 
    {
        [SerializeField] private InputType inputType;
        [SerializeField] private Rigidbody2D rb;
        private PlayerMover PlayerMover;


        void Start()
        {
            UserInput = userInput;
            ComputerInput = computerInput;

            switch (inputType)
            {
                case InputType.User:
                    userInput = new UserInput();
                break;
                case InputType.Computer:
                    computerInput = new ComputerInput();
                break;
            }

            playerMover = new PlayerMover();
            PlayerMover.SetDependencies(userInput, computerInput, rb);
        }

        void Update()
        {
            PlayerMover.Move();
        }
    }

    enum InputType
    {
        User, Computer
    }
}
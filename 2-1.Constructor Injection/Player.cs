namespace DI2
{
    public class Player : MonoBehaviour 
    {
        [SerializeField] private InputType inputType;
        [SerializeField] private Rigidbody rb;
        private PlayerMover PlayerMover;

        void Start()
        {
            UserInput = userInput;
            ComputerInput = computerInput;

            // rb = GetComponent<RigidBody>();
            switch (inputType)
            {
                case InputType.User:
                    userInput = new UserInput();
                break;
                case InputType.Computer:
                    computerInput = new ComputerInput();
                break;
            }

            playerMover = new PlayerMover(userInput, computerInput, rb);
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
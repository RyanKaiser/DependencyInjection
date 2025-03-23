namespace DI2{
    public class PlayerMover
    {
        // [SerializeField] private InputType inputType;

        private Rigidbody2D rb;
        private UserInput userInput;
        private ComputerInput computerInput;

        public PlayerMover(UserInput _userInput, ComputerInput _computerInput, Rigidbody2D _rb)
        {
            userInput = _userInput;
            computerInput = _computerInput;
            rb = _rb;
        }

        // private void Start() 
        // {
        //     rb = GetComponent<Rigidbody2D>();
        //     //
        // }

        public void Move()
        {
            if (userInput != null)
            {

            }
            else if (computerInput != null)
            {

            }
        }

        // enum InputType
        // {
        //     User, Computer
        // }

    }
}
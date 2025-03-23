namespace DI22
{
    public class PlayerMover
    {
        private Rigidbody2D rb;
        private UserInput userInput;
        private ComputerInput computerInput;

        public PlayerMover(UserInput _userInput, ComputerInput _computerInput, Rigidbody2D _rb)
        {
            userInput = _userInput;
            computerInput = _computerInput;
            rb = _rb;
        }

        public void Move()
        {
            if (userInput != null)
            {

            }
            else if (computerInput != null)
            {

            }
        }
    }
}
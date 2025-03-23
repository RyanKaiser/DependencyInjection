namespace DI{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private InputType inputType;

        private Rigidbody2D rb;
        private UserInput userInput;
        private ComputerInput computerInput;

        private void Start() 
        {
            rb = GetComponent<Rigidbody2D>();
            //
        }

        private void Update()
        {
            if (userInput != null)
            {

            }
            else if (computerInput != null)
            {

            }
        }

        enum InputType
        {
            User, Computer
        }

    }
}
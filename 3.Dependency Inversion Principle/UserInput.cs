namespace DI3
{
    public class UserInput : IPlayerInput
    {
        public Vector2 GetMoveVector()
        {
            Vector2 moveVector = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical"));
            
            return moveVector;
        }
    }
}
namespace DI
{
    public class UserInput
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
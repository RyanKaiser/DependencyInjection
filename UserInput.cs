using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjection
{
    public class UserInput : IPlayerInput
    {
        public Vector2 GetMoveVector()
        {
            Vector2 moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            return moveVector;
        }
    }
}
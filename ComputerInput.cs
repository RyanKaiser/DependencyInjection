using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjection
{
    public class ComputerInput : IPlayerInput
    {
        private Vector2 moveVector = Vector2.left;
        private float timer = 0;
        private float changeDirectionTime = 2;
        private Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };

        public Vector2 GetMoveVector()
        {
            if (Time.time > timer)
            {
                moveVector = directions[Random.Range(0, 4)];
                timer = Time.time + changeDirectionTime;
            }

            return moveVector;
        }
    }
}
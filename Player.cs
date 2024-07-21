using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInjection
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private InputType inputType;
        [SerializeField] private Rigidbody2D rb;

        private PlayerMover playerMover;

        void Start()
        {
            IPlayerInput input = null;

            switch (inputType)
            {
                case InputType.User:
                    input = new UserInput();
                    break;
                case InputType.Computer:
                    input = new ComputerInput();
                    break;
            }

            playerMover = new PlayerMover(input, rb);
        }

        void Update()
        {
            playerMover.Move();
        }
    }

    enum InputType
    {
        User, Computer
    }
}
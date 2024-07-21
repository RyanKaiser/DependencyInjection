using UnityEngine;

namespace DependencyInjection
{
    public interface IPlayerInput
    {
        Vector2 GetMoveVector();
    }
}
using UnityEngine;
using Zenject;

namespace AntSimulation
{
    public class AntAgent : MonoBehaviour
    {
        [Inject] public ISticksRepository SticksRepository { get; private set; }
        [Inject] public IAntMoveRepository AntMoveRepository { get; private set; }
    }
}
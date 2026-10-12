using UnityEngine;

namespace AntSimulation
{
    public class AntMoveService : IAntMoveService
    {
        private AntView _view;
        private Transform _target;

        public AntMoveService(AntView view)
        {
            _view = view;
        }

        public void Move()
        {
            if (_target == null) return;

            _view.NavMeshAgent.SetDestination(_target.position);
            SetRotation();
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }

        private void SetRotation()
        {
            Vector3 direction = _view.NavMeshAgent.velocity;
            direction.y = 0;

            if (direction.sqrMagnitude > 0)
            {
                float angleY = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                _view.transform.eulerAngles = new(_view.transform.eulerAngles.x, angleY, _view.transform.eulerAngles.z);
            }
        }
    }
}
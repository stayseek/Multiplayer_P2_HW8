using UnityEngine;
using UnityEngine.Networking;

public class SpiritsMotor : NetworkBehaviour
{

    [SerializeField] float _speed;
    Transform _transform;
    Quaternion _oldRot;

    void Start()
    {
        _transform = transform;
    }

    void Update()
    {
        if (hasAuthority)
        {
            _oldRot = _transform.localRotation;
            _transform.localRotation = Quaternion.Euler(_oldRot.eulerAngles.x, _oldRot.eulerAngles.y + _speed * Time.deltaTime, _oldRot.eulerAngles.z);
        }
    }
}

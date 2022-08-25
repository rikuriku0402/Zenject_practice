using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Move : MonoBehaviour
{
    [Inject]
    IInputProbider _inputProvider;

    [SerializeField]
    [Header("剛体")]
    Rigidbody _rb;

    [SerializeField]
    [Header("ジャンプパワー")]
    float _jumpPower;

    [SerializeField]
    [Header("Playerのスピード")]
    float _speed;

    public void SetInputProvider(IInputProbider input) => _inputProvider = input;

    void Jump() => _rb.AddForce(new Vector3(0, _jumpPower, 0), ForceMode.Impulse);

    private void Update()
    {
        if (_inputProvider.IsJump())
        {
            Jump();
        }
        _rb.AddForce(new Vector3(_inputProvider.GetHorizontal(), 0, _inputProvider.GetVertical() * _speed));
    }
}

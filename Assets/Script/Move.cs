using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Move : MonoBehaviour
{
    [Inject]
    IInputProbider _inputProvider;

    [SerializeField]
    [Header("����")]
    Rigidbody _rb;

    [SerializeField]
    [Header("�W�����v�p���[")]
    float _jumpPower;

    [SerializeField]
    [Header("Player�̃X�s�[�h")]
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

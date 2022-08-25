using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInstantiate : MonoBehaviour
{
    [Inject]
    DiContainer _container;

    [SerializeField]
    GameObject _prefab;


    void Start()
    {
        _container.InstantiatePrefab(_prefab);    
    }
}

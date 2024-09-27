using System.Collections.Generic;
using UnityEngine;

public class PoolObject<T> where T : MonoBehaviour
{
    private Queue<T> _pool;
    private T _prefab;
    private Transform _parent;


    public PoolObject(T prefab, Transform parent, int size, bool isNeedToExpand, bool isNeedToEnable = false)
    {
        _pool = new Queue<T>(size);
        _prefab = prefab;
        _parent = parent;

        for (int i = 0; i < size; i++)
        {
            T newObj = GameObject.Instantiate(_prefab, _parent);
            newObj.gameObject.SetActive(isNeedToEnable);
            _pool.Enqueue(newObj);
        }
    }
}

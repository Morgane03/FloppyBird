using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;

    [SerializeField]
    private GameObject _objectToPool;
    private int _pooledAmount = 5;
    private bool _canGrow;

    private List<GameObject> _pooledObjects;

    public void Awake()
    {
        Instance = this;

        // Créer la liste d'objets dans le pool
        _pooledObjects = new List<GameObject>();
        _canGrow = true;

        // Remplir le pool avec des objets
        for (int i = 0; i < _pooledAmount; i++)
        {
            GameObject obj = Instantiate(_objectToPool);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
        }
    }

    // Obtenir un objet depuis le pool
    public GameObject GetPooledObject()
    {
        // Parcourir la liste des objets du pool
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            // Retourner un objet inactif s'il en existe un
            if (!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }
        // Si aucun objet inactif n'est trouvé et que le pool peut grandir, créer un nouvel objet
        if (_canGrow)
        {
            GameObject obj = Instantiate(_objectToPool);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }
}

using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    
    private void Awake()
    {
        GameObject newCar = Instantiate(_prefab);
        Camera.main.GetComponent<CameraFollow>().SetTarget(newCar);
    }
}

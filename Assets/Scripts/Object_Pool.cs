using System.Collections.Generic;
using UnityEngine;

public class AmmoPool : MonoBehaviour
{
    [SerializeField] private GameObject ammoPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private Transform[] spawnPoints;

    private List<GameObject> ammoPool;
    void Start()
    {
        ammoPool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject ammo = Instantiate(ammoPrefab);
            ammo.SetActive(false);
            ammoPool.Add(ammo);
        }
    }

    public void DropAmmo()
    {
        GameObject ammo = GetPooledAmmo();
        if (ammo != null)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            ammo.transform.position = randomSpawnPoint.position;
            ammo.SetActive(true);
        }
    }
    private GameObject GetPooledAmmo()
    {
        foreach (GameObject ammo in ammoPool)
        {
            if (!ammo.activeInHierarchy)
                return ammo;
        }
        return null;
    }
}
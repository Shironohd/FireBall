using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TowerBilder))]
public class Tower : MonoBehaviour
{
    private TowerBilder _towerBilder;
    private List<Block> _blocks;

    private void Start()
    {
        _towerBilder = GetComponent<TowerBilder>();

        _blocks = _towerBilder.Build();
    }
}

using System.Collections.Generic;
using UnityEngine;

public class TowerBilder : MonoBehaviour
{
    [SerializeField] private int _towerSize;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Block _block;

    public List<Block> Build()
    {
        List<Block> blocks = new List<Block>();

        for(int i = 0; i < _towerSize; i++)
        {
            Block newBlock = BuildBlock();
            blocks.Add(newBlock);
            _spawnPoint = newBlock.transform;
        }
        return blocks;
    }
   

    private Block BuildBlock()
    {
        return Instantiate(_block, GetCurrentBuildPoint(_spawnPoint), Quaternion.identity, transform);
    }

    private Vector3 GetCurrentBuildPoint(Transform previuosBuildPoint)
    {
        return new Vector3(previuosBuildPoint.position.x, previuosBuildPoint.position.y + previuosBuildPoint.localScale.y / 2f +
       _block.transform.localScale.y / 2f, previuosBuildPoint.position.z);


    }
        
}

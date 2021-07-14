using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject gem;

    [SerializeField] private PlayerController _playerController;
    
    private Vector3 prevPos;
    private Vector3 newPos;
    private Vector3 changeVectorLeft;
    private Vector3 changeVectorRight;
    private double change;
    private int rando;
    private int threshold=0;
    
    private void SpawnCube()
        {
            Instantiate(cube,newPos,cube.transform.rotation);
        }

    void SpawnGem()
    {
        _playerController.gem =Instantiate(gem, newPos + new Vector3(0, 1.5f, 0), transform.rotation);
    }
    private void NewSpawnPos()
    {
        rando = Random.Range(0, 2);
        if (rando == 0 && threshold > -4)
        {
            newPos = prevPos + changeVectorLeft;
            threshold--;
        }
        else if (rando == 1 && threshold < 4)
        {
            newPos = prevPos + changeVectorRight;
            threshold++;
        }
        else if (threshold > -4 && threshold < 0)
        {
            newPos = prevPos + changeVectorLeft;
            threshold--;
        }
        else if (threshold < 4 && threshold > 0)
        {
            newPos = prevPos + changeVectorRight;
            threshold++;
        }
        prevPos = newPos;
    }
    private void Start()
    {
        
        change = (float)(Math.Sqrt(2) / 2);
        
        prevPos = new Vector3(0.05f, 1.5f, 17.62f);
        
        changeVectorLeft = new Vector3((float)change, 0, (float)change);
        changeVectorRight = new Vector3((float)-change, 0, (float)change);
        
        
        InvokeRepeating("SpawnCube",0.01f,0.15f);
        InvokeRepeating("SpawnGem",3f,2f);
        InvokeRepeating("NewSpawnPos",0.009f,0.14999f);
        
    }
}

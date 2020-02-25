using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static Inventory instance;

    public static Inventory Instance
    {
        get 
        {
            if (!instance)
                instance = FindObjectOfType<Inventory>();
            return instance; 
        }
    }


    [SerializeField] private GameObject lamp;
    [SerializeField] private GameObject tree;
    [SerializeField] private GameObject rainbow;
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject gramophone;
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject saw;


    private void Awake()
    {
        ClearInventory();
    }

    public void TakeLamp(bool take)
    {
        lamp.SetActive(take);
    }
    public void TakeTree(bool take)
    {
        tree.SetActive(take);
    }


    public void TakeRainbow(bool take)
    {
        rainbow.SetActive(take);
    }

    public void TakeApple(bool take)
    {
        apple.SetActive(take);
    }

    public void TakeGramophone(bool take)
    {
        gramophone.SetActive(take);
    }

    public void TakeBird(bool take)
    {
        bird.SetActive(take);
    }

    public void TakeSaw(bool take)
    {
        saw.SetActive(take);
    }


    public void ClearInventory()
    {
        lamp.SetActive(false);
        tree.SetActive(false);
        rainbow.SetActive(false);
        apple.SetActive(false);
        gramophone.SetActive(false);
        bird.SetActive(false);
        saw.SetActive(false);
    }
}

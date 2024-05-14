using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newgame : MonoBehaviour
{
    void Start()
    {
        canvas1 = GetComponent<GameObject>();
        canvas2 = GetComponent<GameObject>();
    }

    public void btn()
    {
        enemyObject.canvas1.SetActive(false);
        enemyObject.canvas2.SetActive(true);
    }
}

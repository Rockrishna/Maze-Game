using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Transform EndCheck;
    public float EndDistance = 0.4f;
    public LayerMask EndMask;
    bool isEnd;

 

    // Update is called once per frame
    void Update()
    {
        isEnd = Physics.CheckSphere(EndCheck.position, EndDistance, EndMask);
        if(isEnd)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}

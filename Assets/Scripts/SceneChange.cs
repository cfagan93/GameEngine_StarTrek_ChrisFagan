using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{


    public int num;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(num);
        Debug.Log("Scene changed to " + num);

    }

}


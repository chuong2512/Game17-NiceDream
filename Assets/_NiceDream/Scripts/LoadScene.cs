using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("App");
    }
}
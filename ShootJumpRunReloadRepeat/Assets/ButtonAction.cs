using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonAction : MonoBehaviour
{
    // Start is called before the first frame update


    public void PlayButton()
    {
        SceneManager.LoadScene("Demo");
    }
}

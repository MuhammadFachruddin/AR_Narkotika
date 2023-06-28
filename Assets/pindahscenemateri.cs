using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //namespace ini kita gunakan agar dapat memanggil methods untuk berpindah scene yang ada pada class SceneManagement

public class pindahscenemateri : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        //kondisi ketika kita menekan tombol A pada keyboard maka kita akan meload scene yang bernama "scene_satu"
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Method untuk memanggil / berpindah scene yang kita inginkan
            SceneManager.LoadScene("scene_satu");
        }
        //Sedangkan ketika kita menekan tombol Q pada keyboard maka kita akan meload scene yang bernama "scene_dua"
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("scene_dua");
        }

    }

    public void PindahKeSceneDua()
    {
        SceneManager.LoadScene("Materi1");
    }

    public void PindahKeSceneSatu()
    {
        SceneManager.LoadScene("sc");
    }
}
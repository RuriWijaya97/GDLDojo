using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    const string JUDUL = "Selamat Datang Di Game Tebak-Tebakan";
    const string PERTANYAAN = "Air Apa Yang Bikin Sedih?";
    public string[] Jawaban;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{JUDUL} \n {PERTANYAAN}");
        Debug.Log($"{Jawaban[0]} \n {Jawaban[1]}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.LogWarning("Betul");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.LogError("Salah");
        }
    }
}

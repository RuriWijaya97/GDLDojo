using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    const string JUDUL = "Selamat Datang Di Game Tebak-Tebakan";
    const string PERTANYAAN = "Air Apa Yang Bikin Sedih?";
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{JUDUL} \n {PERTANYAAN}");
        Jawaban();
        
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
    
    void Jawaban() {
        Debug.Log($"A. Air Matcha \n B. Air Hujan");
    }
}

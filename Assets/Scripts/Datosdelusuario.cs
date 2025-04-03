using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datosdelusuario : MonoBehaviour
{

    public string nombreUsuario;
    public int edadUsuario;
    public float estaturaUsuario;
    public bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + " tengo " + edadUsuario + " mido " + estaturaUsuario + " es " + esDonante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public GameObject boton;
    public Text HolderContraseña;
    public string contraseña;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Login()
    {
        if (HolderContraseña.text==contraseña)
        {
            Debug.Log("Acces Granted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }
}

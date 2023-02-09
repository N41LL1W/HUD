using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Buttons1 : MonoBehaviour {
    public GameObject person1;
    public GameObject person2;
    public GameObject person3;
    public GameObject botao1;
    public GameObject botao2;
    public GameObject botao3;
    public void ClicarPrimeiraOpcao () {
        person1.SetActive (true);
        person2.SetActive (false);
        person3.SetActive (false);
        botao1.SetActive (true);
        botao2.SetActive (false);
        botao3.SetActive (false);
    }
    public void ClicarSegundaOpcao () {
        person2.SetActive (true);
        person1.SetActive (false);
        person3.SetActive (false);
        botao1.SetActive (false);
        botao2.SetActive (true);
        botao3.SetActive (false);
    }
    public void ClicarTerceiraOpcao () {
        person3.SetActive (true);
        person2.SetActive (false);
        person1.SetActive (false);
        botao1.SetActive (false);
        botao2.SetActive (false);
        botao3.SetActive (true);
    }
    public void ClicarPrimeiroBotão () {
        SceneManager.LoadScene ("GamePlay");
    }
    public void ClicarSegundoBotão () {
        SceneManager.LoadScene ("GamePlay");
    }
    public void ClicarTerceiroBotão () {
        SceneManager.LoadScene ("GamePlay");
    }
}
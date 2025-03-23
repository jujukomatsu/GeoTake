using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudançadeCena : MonoBehaviour
{
    [SerializeField] private string CenaJogar;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void Jogar()
    {
        Debug.Log("Inciando o jogo");
        SceneManager.LoadScene(CenaJogar);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void Sair()
    {
        Debug.Log("Saindo do Jogo");
        Application.Quit();
    }

    public void VoltarParaMenu()
    {
        SceneManager.LoadScene("Tela de Menu"); // Certifique-se de que a cena tem esse nome no Build Settings
    }
}

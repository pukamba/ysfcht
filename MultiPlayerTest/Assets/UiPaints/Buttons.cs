using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button startB, settingsB, exitB, hostB, lobbyB, backB;
    private Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void NextPage()
    {
        anim.SetTrigger("NextPage");
    }
    public void PrevPage()
    {
        anim.SetTrigger("PrevPage");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject loseMenu;

    void OnTriggerEnter2D(Collider2D col)
    {
        ///Enter gate on collision with player

        if (col.gameObject.tag.Equals("Player"))
        {
            FindObjectOfType<GameMenu>().canvas.enabled = true;

            loseMenu.SetActive(false);
            winMenu.SetActive(true);
        }
    }
}

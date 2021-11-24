using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject prefabAddChips;
    public GameObject Parent;
    public void CreatyAddChips() {
        Instantiate(prefabAddChips, Parent.transform.parent);
    }
}
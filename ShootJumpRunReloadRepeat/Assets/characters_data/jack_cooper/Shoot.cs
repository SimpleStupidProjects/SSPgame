using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;

    // Start is called before the first frame update
    private void Awake()
    {
        GetComponent<CharacterAim_Basse>().OnShoot += PlayerShootProjeciles_OnShoot;
    }

    // Update is called once per frame
    private void PlayerShootProjeciles_OnShoot(object sender, CharacterAim_Base.OnShootEventArgs e)
    {
        
    }
}

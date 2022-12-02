using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    BoxCollider damageCollider;
    public int weaponDamage = 25;

    private void Awake(){
        damageCollider = GetComponent<BoxCollider>();
        damageCollider.gameObject.SetActive(true);
        damageCollider.isTrigger = true;
        damageCollider.enabled = false;

    }

    public void EnableDamageCollider(){
        Debug.Log("enable sword");
        damageCollider.enabled = true;
    }

    public void DisableDamageCollider(){

        damageCollider.enabled = false;
    }

   private void OnTriggerEnter(Collider other){

        Debug.Log("entered");
        print("hello");
        if(other.gameObject.tag == "Player"){

            PlayerStats playerStats = other.GetComponent<PlayerStats>();
        
        if(playerStats != null){

            playerStats.TakeDamage(weaponDamage);
        }
        }
        if(other.gameObject.tag == "enemy"){
            Debug.Log("enemy collider");
            EnemyStats enemyStats = other.GetComponent<EnemyStats>();
            
        
        if(enemyStats != null){
            
            enemyStats.TakeDamage(weaponDamage);
        }
        }
    }
}

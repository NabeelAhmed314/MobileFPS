using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectWeapon();    
    }

    public void SwitchToPrimary()
    {
        selectedWeapon = 0;
        selectWeapon();
        Debug.Log("Switch to primary: " +selectedWeapon);
    }

    public void SwitchToSecondary()
    {
        selectedWeapon = 1;
        selectWeapon();
        Debug.Log("Switch to secondary: " +selectedWeapon);
    }

    void selectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if(i == selectedWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace JinGroup.Base.MenuController {
    public class ButtonFunctionController : MonoBehaviour
    {
        public GameObject Menu;
        public GameObject Ship1;
        public GameObject Ship2;
        public GameObject Ship3;
        public GameObject Ship4;
        public GameObject Ship5;
        public GameObject Ship6;
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 0;
        }
        // Update is called once per frame
        void Update()
        {

        }
        public void Player1()
        {
            Ship1.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
        public void Player2()
        {
            Ship2.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
        public void Player3()
        {
            Ship3.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
        public void Player4()
        {
            Ship4.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
        public void Player5()
        {
            Ship5.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
        public void Player6()
        {
            Ship6.SetActive(true);
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
    }

}

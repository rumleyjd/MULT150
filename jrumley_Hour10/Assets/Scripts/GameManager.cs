using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange, chaos1, chaos2, chaos3, chaos4;
    private bool isGameOver = true;

    public int time = 0;

    void Update ()
    {
        // If all four goals are solved then the game is over
       isGameOver = blue.isSolved && chaos1.isSolved && chaos2.isSolved && chaos3.isSolved && chaos4.isSolved && green.isSolved && red.isSolved &&  orange.isSolved;
        if(isGameOver) {
            time += 1;
        }
    }

void OnGUI()
    {
       if(isGameOver)
       {
           Rect rect = new Rect (Screen.width / 2 - 100, Screen.height /  2 - 50, 200, 75);
           GUI.Box (rect, "Game Over");
           Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height /  2 - 25, 60, 50);
           GUI.Label (rect2, "Good Job!");
           Rect rect3 = new Rect (Screen.width / 2 + 60, Screen.height /  2 - 25, 60, 50);
           GUI.Label (rect3, "Time: " + (time/165).ToString());
         }
      }
}

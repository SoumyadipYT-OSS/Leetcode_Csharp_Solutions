public class Solution {
    public bool WinnerOfGame(string colors) {
        int length = colors.Length;
        int countAliceMove = 0;
        int countBobMove = 0;

        for (int i = 1; i < length - 1; i++){
            if (colors[i - 1] != colors[i] || colors[i] != colors[i + 1]){
                continue;
            }
            if (colors[i] == 'A'){
                countAliceMove++;
            }
            else{
                countBobMove++;
            }
        }

        return countAliceMove > countBobMove;
    }
}
public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        int m = heightMap.Length;
        int n = heightMap[0].Length;
        Console.WriteLine($"m:{m}, n:{n}");

        int[,] waterLevelMap = new int[m, n];


        for (int i = 1; i < m - 1; i++) {
            waterLevelMap[i, 0] = heightMap[i][0]; // left
            for (int j = 1; j < n - 1; j++) {
                waterLevelMap[i, j] = int.MaxValue;
            }
            waterLevelMap[i, n -1 ] = heightMap[i][n-1]; // right
        }

        for (int j = 0; j < n; j++) {
            waterLevelMap[0, j] = heightMap[0][j];          // top
            waterLevelMap[m - 1, j] = heightMap[m-1][j];    // bottom
        }

        bool done = false;
        while (!done) {
            done = true;
            for (int i = 1; i < n-1; i++) {
                for (int j = 1; j < m-1; j++) {
                    //Console.WriteLine($"\nwaterLevelMap[{j}, {i}]:{waterLevelMap[j, i]}, heightMap[{j}][{i}]:{heightMap[j][i]}");
                    if (waterLevelMap[j, i] <= heightMap[j][i]) {
                        continue;
                    }
                    //int min = Math.Min(waterLevelMap[j, i-1], waterLevelMap[j-1, i]);
                   // waterLevelMap[j, i] = Math.Max(min, heightMap[j][i]);
                    //Console.WriteLine($"set waterLevelMap[{j}, {i}]:{waterLevelMap[j, i]}");


                    //*
                    if (waterLevelMap[j, i] > heightMap[j][i]) {
                        // Compare witg the left cell
                        if (waterLevelMap[j, i] > waterLevelMap[j, i-1]) {
                            waterLevelMap[j, i] = Math.Max(waterLevelMap[j, i-1], heightMap[j][i]);
                            //Console.WriteLine($"set waterLevelMap[{j}, {i}]:{waterLevelMap[j, i]}");
                        }

                        // Compare with the up cell
                        if (waterLevelMap[j, i] > waterLevelMap[j-1, i]) {
                            waterLevelMap[j, i] = Math.Max(waterLevelMap[j-1, i], heightMap[j][i]);
                             //Console.WriteLine($"set waterLevelMap[{j}, {i}] (2):{waterLevelMap[j, i]}");
                        }
                    }
                    //*/
                }
            }


            // SCAN From bottom to up, right to left
            Console.WriteLine("\nSCAN From bottom to up, right to left");
          for (int i = n-2; i > 0; i--) {
                for (int j =m-2; j > 0; j--) {
                     //if (waterLevelMap[j, i] <= heightMap[j][i]) {
                        //continue;
                     //}

                    //int low = Math.Min(waterLevelMap[j, i+1], waterLevelMap[j+1, i]);
                    //waterLevelMap[j, i] = Math.Max(low, heightMap[j][i]);
                    //*
                    if (waterLevelMap[j, i] > heightMap[j][i]) {
                        /*
                        //Console.WriteLine($"\nwaterLevelMap[{j}, {i}]: {waterLevelMap[j, i]}");
                        //Console.WriteLine($"waterLevelMap[{j}, {i+1}]: {waterLevelMap[j, i+1]}");
                        //Console.WriteLine($"waterLevelMap[{j+1}, {i}]: {waterLevelMap[j+1, i]}");
                        //Console.WriteLine($"heightMap[{j}][{i}]: {heightMap[j][i]}");

                        if (waterLevelMap[j, i] > waterLevelMap[j, i+1])
                            waterLevelMap[j, i] = Math.Max(waterLevelMap[j, i+1], heightMap[j][i]);
                        if (waterLevelMap[j, i] > waterLevelMap[j+1, i])
                            waterLevelMap[j, i] = Math.Max(waterLevelMap[j+1, i], heightMap[j][i]);
                        */
                        
                        int low = Math.Min(waterLevelMap[j, i+1], waterLevelMap[j+1, i]);
                        if (waterLevelMap[j, i] > low) {
                            waterLevelMap[j, i] = Math.Max(low, heightMap[j][i]);
                        }
                        //Console.WriteLine($"\nwaterLevelMap[{j}, {i}]: {waterLevelMap[j, i]}, low:{low}, max:{Math.Max(low, heightMap[j][i])}");
                        //if (waterLevelMap[j, i] != Math.Max(low, heightMap[j][i])) {
                        //    Console.WriteLine("Weird!!!");
                        //}
                        if (waterLevelMap[j, i] < waterLevelMap[j, i+1] && waterLevelMap[j, i+1] > heightMap[j][i+1]
                            || waterLevelMap[j, i] < waterLevelMap[j+1, i] && waterLevelMap[j+1, i] > heightMap[j+1][i]) {
                            done = false;
                        }
                    }
                    /*
                    if ((waterLevelMap[j, i] < waterLevelMap[j, i+1] && waterLevelMap[j, i+1] > heightMap[j][i+1])
                            || (waterLevelMap[j, i] < waterLevelMap[j+1, i] && waterLevelMap[j+1, i] > heightMap[j+1][i])) {
                            done = false;
                    }
                    */
                }
            }

        }

        int trappedWater = 0;
        for (int i = 1; i < m-1; i++) {
            for (int j = 1; j < n-1; j++) {
                trappedWater += waterLevelMap[i, j] - heightMap[i][j];
            }
        }

        return trappedWater;
    }
}

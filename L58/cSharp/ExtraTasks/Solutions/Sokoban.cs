using Util;

namespace ExtraTaskSolutions
{
    class Sokoban
    {
        public static void RunAll(){
            Run();
            Run_();
        }

        public static void Run(){
            char[][] map = new char[][]{
                new char[]{'#','#','#','#','#','#','#'},
                new char[]{'#',' ','.',' ',' ',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#',' ',' ','@',' ',' ','#'},
                new char[]{'#',' ',' ',' ','$',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#','#','#','#','#','#','#'}
            };

            do
            {
                bool winCondition = true;
                foreach (var y in map)
                {
                    foreach (var x in y)
                    {
                        Console.Write(x);
                        if (x == '.' || x == '+')
                        {
                            winCondition = false;
                        }
                    }
                    Console.WriteLine();
                }
                if (winCondition)
                {
                    Console.WriteLine("Winner!");
                    return;
                }
                Console.WriteLine("What do you want do do?");
                Console.WriteLine("Left/Up/Right/Down");
                int xDirection = 0;
                int yDirection = 0;
                switch (Console.ReadLine().ToLower())
                {
                    case "left":
                        xDirection = -1;
                        break;
                    case "up":
                        yDirection = -1;
                        break;
                    case "right":
                        xDirection = 1;
                        break;
                    case "down":
                        yDirection = 1;
                        break;
                    case "exit":
                        Console.WriteLine("End!");
                        return;
                    default:
                        Console.WriteLine("Coudnt read command");
                        continue;
                }

                int playerXPos = -1;
                int playerYPos = -1;
                bool isOnDestionationField = false;

                for (int y = 0; y < map.Length; y++)
                {
                    for (int x = 0; x < map[y].Length; x++)
                    {
                        char potentialPos = map[y][x];
                        if (potentialPos == '@' || potentialPos == '+')
                        {
                            if (potentialPos == '+')
                            {
                                isOnDestionationField = true;
                            }
                            playerXPos = x;
                            playerYPos = y;
                        }
                    }
                }
                if (playerXPos < 0 || playerYPos < 0)
                {
                    Console.WriteLine("Coudnt find player!");
                    return;
                }
                char moveField = map[playerYPos + yDirection][playerXPos + xDirection];
                switch (moveField)
                {
                    case ' ':
                        map[playerYPos + yDirection][playerXPos + xDirection] = '@';
                        if (isOnDestionationField)
                        {
                            map[playerYPos][playerXPos] = '.';
                        }else
                        {
                            map[playerYPos][playerXPos] = ' ';
                        }
                        break;
                    case '.':
                        map[playerYPos + yDirection][playerXPos + xDirection] = '+';
                        if (isOnDestionationField)
                        {
                            map[playerYPos][playerXPos] = '.';
                        }else
                        {
                            map[playerYPos][playerXPos] = ' ';
                        }
                        break;
                    case '#':
                        break;
                    case '*':
                        char behindMoveField = map[playerYPos + yDirection*2][playerXPos + xDirection*2];
                        if (behindMoveField != '#' && behindMoveField != '$')
                        {
                            map[playerYPos + yDirection][playerXPos + xDirection] = '+';
                            if (isOnDestionationField)
                            {
                                map[playerYPos][playerXPos] = '.';
                            }else
                            {
                                map[playerYPos][playerXPos] = ' ';
                            }
                            if (behindMoveField == '.')
                            {
                                map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '*';
                            }else{
                                map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '$';
                            }
                        }
                        break;
                    case '$':
                        behindMoveField = map[playerYPos + yDirection*2][playerXPos + xDirection*2];
                        if (behindMoveField != '#' && behindMoveField != '$')
                        {
                            map[playerYPos + yDirection][playerXPos + xDirection] = '@';
                            if (isOnDestionationField)
                            {
                                map[playerYPos][playerXPos] = '.';
                            }else
                            {
                                map[playerYPos][playerXPos] = ' ';
                            }
                            if (behindMoveField == '.')
                            {
                                map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '*';
                            }else{
                                map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '$';
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Coudnt read map!");
                        return;
                }
            } while (true);
        }

        public static void Run_(){
            SokobanMap sokobanMap = new SokobanMap();
            do
            {
                if (sokobanMap.isWon())
                {
                    Console.WriteLine("Winner!");
                    return;
                }
                Console.WriteLine(sokobanMap);
                Console.WriteLine("What do you want do do?");
                Console.WriteLine("Left/Up/Right/Down");
                String command = Console.ReadLine();
                switch (command != null ? command.ToLower(): "")
                {
                    case "exit":
                        Console.WriteLine("End!");
                        return;
                    default:
                        CEnumField<int[]> direction = Direction.OfString(command);
                        if(direction == null) continue;
                        sokobanMap.Move(direction);
                        break;
                }
            } while (true);
        }

        class SokobanMap
        {
            public Direction direction = new();
            char[][] map = new char[][]{
                new char[]{'#','#','#','#','#','#','#'},
                new char[]{'#',' ','.',' ',' ',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#',' ',' ','@',' ',' ','#'},
                new char[]{'#',' ',' ',' ','$',' ','#'},
                new char[]{'#',' ',' ',' ',' ',' ','#'},
                new char[]{'#','#','#','#','#','#','#'}
            };
            int playerYPos = -1;
            int playerXPos = -1;
            public SokobanMap(){
                UpdatePlayerPos();
            }

            public bool isWon(){
                foreach (var y in map)
                {
                    foreach (var x in y)
                    {
                        if (x == '.' || x == '+')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            private void UpdatePlayerPos(){
                for (int y = 0; y < map.Length; y++)
                {
                    for (int x = 0; x < map[y].Length; x++)
                    {
                        if (map[y][x] == '@' || map[y][x] == '+')
                        {
                            playerYPos = y;
                            playerXPos = x;
                            return;
                        }
                    }
                }
            }

            public void Move(CEnumField<int[]> direction){
                int yDirection = direction.GetValue()[0];
                int xDirection = direction.GetValue()[1];
                switch (map[playerYPos + yDirection][playerXPos + xDirection])
                {
                    case '#':
                        return;
                    case ' ':
                    case '.':
                        MovePlayer(yDirection,xDirection);
                        break;
                    case '$':
                    case '*':
                        if(MoveBox(yDirection,xDirection)){
                            MovePlayer(yDirection,xDirection);
                        }
                        break;
                    default:
                        return;
                }
            }

            private void MovePlayer(int yDirection, int xDirection){
                if(map[playerYPos + yDirection][playerXPos + xDirection] == '.'){
                    map[playerYPos + yDirection][playerXPos + xDirection] = '+';
                }else{
                    map[playerYPos + yDirection][playerXPos + xDirection] = '@';
                }
                if (map[playerYPos][playerXPos] == '+')
                {
                    map[playerYPos][playerXPos] = '.';
                }else
                {
                    map[playerYPos][playerXPos] = ' ';
                }
                UpdatePlayerPos();
            }

            private bool MoveBox(int yDirection, int xDirection){
                char box = map[playerYPos + yDirection][playerXPos + xDirection];
                char behindMap = map[playerYPos + yDirection*2][playerXPos + xDirection*2];
                if (behindMap == ' ' || behindMap == '.')
                {
                    if (box == '*')
                    {
                        map[playerYPos + yDirection][playerXPos + xDirection] = '.';
                    }else
                    {
                        map[playerYPos + yDirection][playerXPos + xDirection] = ' ';
                    }
                    if (behindMap == '.')
                    {
                        map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '*';
                    }else
                    {
                        map[playerYPos + yDirection*2][playerXPos + xDirection*2] = '$';
                    }
                    return true;
                }
                return false;
            }
            override
            public String ToString(){
                String output = "";
                foreach (var y in map)
                {
                    foreach (var x in y)
                    {
                        output += x;
                    }
                    output += "\n";
                }
                return output;
            }
        }
    }
    class Direction : CEnum<int[]>{
        public static readonly CEnumField<int[]> UP = new("UP", new int[]{-1,0});
        public static readonly CEnumField<int[]> DOWN = new("DOWN", new int[]{1,0});
        public static readonly CEnumField<int[]> LEFT = new("LEFT", new int[]{0,-1});
        public static readonly CEnumField<int[]> RIGHT = new("RIGHT", new int[]{0,1});

        static Direction(){
            cEnum.Add(UP);
            cEnum.Add(DOWN);
            cEnum.Add(LEFT);
            cEnum.Add(RIGHT);
        }
    }
}
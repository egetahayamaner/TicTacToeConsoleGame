
using System.Threading.Channels;

namespace TicTacToe
{
    class program
    {
        private static string _input;
        private static bool _player1;
        private static bool _gameOver;
        private static int _turns;
        private static int _player1Score;
        private static int _player2Score;

        private static string[,] _field = new string[3, 3]
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };

        static void ResetGame()
        {
            Console.WriteLine();
            Console.WriteLine("PLAYER1 - " + _player1Score + "-" + _player2Score + " - PLAYER2");
            Console.WriteLine();
            _field = new string[3, 3]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };
            Board();
            _turns = 0;
            _player1 = true;
            _gameOver = false;
        }

        static void Board()
        {
            Console.WriteLine("-------------------------");
            for (int i = 0; i < _field.GetLength(0); i++)
            {
                Console.WriteLine("|       |       |       |");
                Console.Write("|");
                for (int j = 0; j < _field.GetLength(1); j++)
                {
                    Console.Write("   " + _field[i, j] + "   ");
                    Console.Write("|");
                }

                Console.WriteLine();
                Console.WriteLine("|       |       |       |");
                Console.WriteLine("-------------------------");
               
            }
        }

        static void Selection()
        {
            string stamp = "O";
            if (_player1)
            {
                stamp = "O";
                Console.Write("Player 1: Choose your field! ");
                _input = Console.ReadLine();
                _player1 = false;
            }
            else if (!_player1)
            {
                stamp = "X";
                Console.Write("Player 2: Choose your field! ");
                _input = Console.ReadLine();
                _player1 = true;
            }

            end: ;
            if (_input == _field[0, 0])
            {
                _field[0, 0] = stamp;
                _turns++;
            }
            else if (_input == _field[0, 1])
            {
                _field[0, 1] = stamp;
                _turns++;
            }
            else if (_input == _field[0, 2])
            {
                _field[0, 2] = stamp;
                _turns++;
            }
            else if (_input == _field[1, 0])
            {
                _field[1, 0] = stamp;
                _turns++;
            }
            else if (_input == _field[1, 1])
            {
                _field[1, 1] = stamp;
                _turns++;
            }
            else if (_input == _field[1, 2])
            {
                _field[1, 2] = stamp;
                _turns++;
            }
            else if (_input == _field[2, 0])
            {
                _field[2, 0] = stamp;
                _turns++;
            }
            else if (_input == _field[2, 1])
            {
                _field[2, 1] = stamp;
                _turns++;
            }
            else if (_input == _field[2, 2])
            {
                _field[2, 2] = stamp;
                _turns++;
            }
            else if (!(_input == "1" || _input == "2" || _input == "3" || _input == "4" || _input == "5" ||
                       _input == "6" || _input == "7" || _input == "8" || _input == "9"))
            {
                Console.WriteLine("Please enter a number!");
                Console.WriteLine("Incorrect input! please use another field!");
                if (!_player1)
                {
                    Console.Write("Player 1: Choose your field! ");
                }
                else if (_player1)
                {
                    Console.Write("Player 2: Choose your field! ");
                }

                _input = Console.ReadLine();
                goto end;
            }
            else
            {
                Console.WriteLine("Incorrect input! please use another field!");
                if (!_player1)
                {
                    Console.Write("Player 1: Choose your field! ");
                }
                else if (_player1)
                {
                    Console.Write("Player 2: Choose your field! ");
                }

                _input = Console.ReadLine();
                goto end;
            }
        }

        static void Checker()
        {
            for (int i = 0; i < _field.GetLength(0); i++)
            {
                for (int j = 0; j < _field.GetLength(1); j++)
                {
                    if (_field[i, 0] == _field[i, 1] && _field[i, 1] == _field[i, 2])
                    {
                        _gameOver = true;
                        if (_player1 == false)
                        {
                            Console.WriteLine("Player 1 has won!");
                            _player1Score++;
                            Console.WriteLine("Press and Key to Reset the game");
                            Console.ReadKey();
                            ResetGame();
                            break;
                        }
                        else if (_player1 == true)
                        {
                            Console.WriteLine("Player 2 has won!");
                            _player2Score++;
                            Console.WriteLine("Press and Key to Reset the game");
                            Console.ReadKey();
                            ResetGame();
                            break;
                        }
                    }
                    else if (_field[0, j] == _field[1, j] && _field[1, j] == _field[2, j])
                    {
                        _gameOver = true;
                        if (_player1 == false)
                        {
                            Console.WriteLine("Player 1 has won!");
                            _player1Score++;
                            Console.WriteLine("Press and Key to Reset the game");
                            Console.ReadKey();
                            ResetGame();
                            break;
                        }
                        else if (_player1 == true)
                        {
                            Console.WriteLine("Player 2 has won!");
                            _player2Score++;
                            Console.WriteLine("Press and Key to Reset the game");
                            Console.ReadKey();
                            ResetGame();
                            break;
                        }
                    }
                }
            }
            
            if (_field[0, 0] == _field[1, 1] && _field[1, 1] == _field[2, 2])
            {
                _gameOver = true;
                if (_player1 == false)
                {
                    Console.WriteLine("Player 1 has won!");
                    _player1Score++;
                    Console.WriteLine("Press and Key to Reset the game");
                    Console.ReadKey();
                }
                else if (_player1 == true)
                {
                    Console.WriteLine("Player 2 has won!");
                    _player2Score++;
                    Console.WriteLine("Press and Key to Reset the game");
                    Console.ReadKey();
                }
            }
            else if (_field[0, 2] == _field[1, 1] && _field[1, 1] == _field[2, 0])
            {
                _gameOver = true;
                if (_player1 == false)
                {
                    Console.WriteLine("Player 1 has won!");
                    _player1Score++;
                    Console.WriteLine("Press and Key to Reset the game");
                    Console.ReadKey();
                    ResetGame();
                }
                else if (_player1 == true)
                {
                    Console.WriteLine("Player 2 has won!");
                    _player2Score++;
                    Console.WriteLine("Press and Key to Reset the game");
                    Console.ReadKey();
                    ResetGame();
                }
            }
            else if (_turns == 9)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("Press and Key to Reset the game");
                Console.ReadKey();
                ResetGame();
            }
        }

        public static void Main(string[] args)
        {
            _player1 = true;
            _gameOver = false;
            
            while (true)
            {
                ResetGame();
                while (!_gameOver)
                {
                    Selection();
                    Board();
                    Checker();
                }
            }
        }
    }
}
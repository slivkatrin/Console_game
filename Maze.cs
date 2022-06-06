using System;
using System.IO;
using System.Reflection;
namespace GameProject
{
    public class Maze
    {

        private Field[,] feelds;
        private int sizeX, sizeY;

        public Maze()
        {
            sizeX = 40;
            sizeY = 13;
            feelds = new Field[sizeX, sizeY]; //конструктор таблицы на поля

            loadFile();
        }

        public int getSizeX() 
        {
            return sizeX;
        }

        public int getSizeY()
        {
            return sizeY;
        }

        public char GetFieldSymbol(int x,int y) //which symbol
        {
            return feelds[x, y].getSymbol();
        }

        public void SetField(int x,int y,Field f)
        {
            feelds[x, y] = f; // wstaw pole w polozeniu X/Y
        }

        public Field GetField(int x,int y) // which field return field
        {
            return feelds[x, y];
        }


        
        private bool loadFile() // download map from the txt file
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "GameProject.map.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
             using (StreamReader reader = new StreamReader(stream)) // download finished 
            {
                uint x = 0; //reading map from the 0 0
                uint y = 0;
                while (!reader.EndOfStream) //while file is not finished
                {
                    if (y >= sizeY) break; // if more than 13 stop reading
                    string result = reader.ReadLine(); // load 1 line
                    foreach (char symbols in result) // go over every symbol in the line
                    {
                        if (x >= sizeX) break;// if there are many symbols in the line, we do not read it
                        if (symbols == ' ')
                        {
                            feelds[x, y] = new EmptyField(x,y,this);
                        }
                        if (symbols == '$')
                        {
                            feelds[x, y] = new GoldField(x, y,this);
                        }
                        if (symbols == '♥')
                        {
                            feelds[x, y] = new HealthField(x, y,this);
                        }
                        if (symbols == '#')
                        {
                            feelds[x, y] = new WallField(x, y,this);
                        }
                        if (symbols == '✖')
                        {
                            feelds[x, y] = new GameFinishField(x, y, this);
                            
                        }
                        if (symbols == 'M')
                        {
                            Monster M = new Monster(10, 23, 1, 35, 4);
                            feelds[x, y] = new MonsterField(x, y,this,M); //creating a monster with parametr 
                            
                        }

                        x++; // go to the cell to the right in the maze array
                    }
                    for (;x<sizeX;x++) // если мало комнат в линии то вставь пустые комнаты 
                    {
                        feelds[x, y] = new EmptyField(x, y,this); 
                    }
                    y++; // go down one cell in the maze array
                    x = 0; // 
                }
                
            }
            return true;
        }
    }
}
